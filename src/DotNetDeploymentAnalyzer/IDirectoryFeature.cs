using DotNetDeploymentAnalyzer.Models;

namespace DotNetDeploymentAnalyzer;

public interface IDirectoryFeature
{
    DirectoryFeatureAnalyzeResponse AnalyzeDirectory(string directoryPath);

}