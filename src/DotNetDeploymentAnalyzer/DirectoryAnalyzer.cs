using DotNetDeploymentAnalyzer.Models;
using Microsoft.Extensions.Logging;

namespace DotNetDeploymentAnalyzer;

public class DirectoryAnalyzer : IDirectoryAnalyzer
{
    private readonly ILogger<DirectoryAnalyzer>? _logger;

    public DirectoryAnalyzer(ILogger<DirectoryAnalyzer>? logger = null)
    {
        _logger = logger;
    }

    public DirectoryAnalyzeResponse AnalyzeDirectory(DirectoryAnalyzeRequest? request)
    {
        if (request?.FullPath == null)
        {
            throw new ArgumentNullException(nameof(request.FullPath));
        }

        DirectoryInfo directoryInfo = new(request!.FullPath!);
        if (!directoryInfo.Exists)
        {
            return new DirectoryAnalyzeResponse() { Status = DirectoryAnalysisStatusEnum.Missing };
        }

        DirectoryAnalyzeResponse response = new();


        response.DirectoryFeatureAnalyzeResponses =
            FeatureRegistry.DirectoryFeatures?.Select(feature => feature?.AnalyzeDirectory(directoryInfo.FullName));
        var files = directoryInfo.GetFiles(request.SearchPattern ?? String.Empty);
        response.AssemblyFeatureAnalyzeResponses = files.SelectMany(file =>
        {
            var applicableFeatures =
                FeatureRegistry.FileFeatures?.Where(feature => feature?.CanAnalyzeFile(file.FullName) ?? false);
            return applicableFeatures?.Select(feature => feature?.AnalyzeFile(file.FullName!)) ?? Array.Empty<FileFeatureAnalyzeResponse?>();
        });
        return response;
    }
}