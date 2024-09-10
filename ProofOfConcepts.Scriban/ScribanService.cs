using PuppeteerSharp;
using Scriban;
using Scriban.Runtime;

namespace ProofOfConcepts.Scriban;

public class ScribanService
{
    public string RenderTemplate(IDictionary<string, object> scriptObjects, string fullPath)
    {
        var templateString = File.ReadAllText(fullPath);
        var templateContext = GetTemplateContext(scriptObjects);
        var template = Template.Parse(templateString);
        return template.Render(templateContext);
    }

    public async Task<byte[]> RenderTemplateAsPdf(IDictionary<string, object> scriptObjects, string fullPath)
    {
        var templateString = File.ReadAllText(fullPath);
        var templateContext = GetTemplateContext(scriptObjects);
        var template = Template.Parse(templateString);

        return await ConvertRenderToPdf(template.Render(templateContext));
    }

    public async Task<byte[]> ConvertRenderToPdf(string render)
    {
        // download the browser executable
        await new BrowserFetcher().DownloadAsync();

        // browser execution configs
        var launchOptions = new LaunchOptions
        {
            Headless = true, // = false for testing
        };

        // open a new page in the controlled browser
        using (var browser = await Puppeteer.LaunchAsync(launchOptions))
        using (var page = await browser.NewPageAsync())
        {
            await page.SetContentAsync(render);
            var result = await page.GetContentAsync();
            return await page.PdfDataAsync();
        }
    }

    public TemplateContext GetTemplateContext(IDictionary<string, object> scriptObjects)
    {
        var templateContext = new TemplateContext
        {
            TemplateLoader = new ScribanTemplateLoader(),
            MemberRenamer = member => member.Name, // Use C# object names instead of converting to pascal case.
            AutoIndent = false
        };

        var scriptObject = new ScriptObject();
        foreach (var newScriptObject in scriptObjects)
        {
            scriptObject.Add(newScriptObject.Key, newScriptObject.Value);
        }

        templateContext.PushGlobal(scriptObject);

        return templateContext;
    }
}