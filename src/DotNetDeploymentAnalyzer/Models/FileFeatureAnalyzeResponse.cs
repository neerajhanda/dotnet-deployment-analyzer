namespace DotNetDeploymentAnalyzer.Models;

public class FileFeatureAnalyzeResponse
{
    private readonly string? _filePath;

    public FileFeatureAnalyzeResponse(string? filePath)
    {
        _filePath = filePath;
    }
    
}