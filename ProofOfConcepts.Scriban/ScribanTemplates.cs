namespace ProofOfConcepts.Scriban;

public class ScribanTemplates
{
    public static readonly string Quote = Path.Combine(ScribanPaths.DefaultPath, "Quote", "Quote.html");
}

public static class ScribanPaths
{
    public static string DefaultPath
    {
        get
        {
            // Allows browser reloads to test template changes.
            if (System.Diagnostics.Debugger.IsAttached) return "../ProofOfConcepts.Scriban/Templates/";
            else return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates");
        }
    }
}
