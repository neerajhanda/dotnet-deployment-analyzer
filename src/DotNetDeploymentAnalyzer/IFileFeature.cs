using DotNetDeploymentAnalyzer.Models;

namespace DotNetDeploymentAnalyzer;

public interface IFileFeature
{
    bool CanAnalyzeFile(string filePath);
    FileFeatureAnalyzeResponse AnalyzeFile(string filePath);
}