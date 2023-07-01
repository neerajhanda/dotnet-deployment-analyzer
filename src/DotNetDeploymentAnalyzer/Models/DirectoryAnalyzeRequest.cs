namespace DotNetDeploymentAnalyzer.Models;

public class DirectoryAnalyzeRequest
{
    public string? FullPath { get; set; }
    public string? SearchPattern { get; set; }
}