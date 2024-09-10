using Scriban.Parsing;
using Scriban;
using Scriban.Runtime;

namespace ProofOfConcepts.Scriban;

public class ScribanTemplateLoader : ITemplateLoader
{
    public string GetPath(TemplateContext context, SourceSpan callerSpan, string templateName)
    {
        return ScribanPaths.DefaultPath + templateName;
    }

    public string Load(TemplateContext context, SourceSpan callerSpan, string templatePath)
    {
        return File.ReadAllText(templatePath);
    }

    public ValueTask<string> LoadAsync(TemplateContext context, SourceSpan callerSpan, string templatePath)
    {
        throw new NotImplementedException();
    }
}
