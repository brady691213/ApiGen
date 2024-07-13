namespace Decompiler;

public class PropertySourceDec(string declaringFile, string matchedDec)
{
    public string DeclaringFile { get; set; } = declaringFile;

    public string MatchedDec { get; set; } = matchedDec;
}