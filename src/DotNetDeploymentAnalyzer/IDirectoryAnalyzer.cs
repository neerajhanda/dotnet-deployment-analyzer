using DotNetDeploymentAnalyzer.Models;

namespace DotNetDeploymentAnalyzer;

public interface IDirectoryAnalyzer
{
    DirectoryAnalyzeResponse? AnalyzeDirectory(DirectoryAnalyzeRequest? request);
}