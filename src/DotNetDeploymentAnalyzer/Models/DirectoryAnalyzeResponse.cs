namespace DotNetDeploymentAnalyzer.Models;

public class DirectoryAnalyzeResponse
{
    public DirectoryAnalysisStatusEnum Status { get; set; }
    public IEnumerable<DirectoryFeatureAnalyzeResponse?>? DirectoryFeatureAnalyzeResponses { get; set; }
    public IEnumerable<FileFeatureAnalyzeResponse?>? AssemblyFeatureAnalyzeResponses { get; set; }
}