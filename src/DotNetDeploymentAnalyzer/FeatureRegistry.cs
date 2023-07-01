namespace DotNetDeploymentAnalyzer;

public static class FeatureRegistry
{
    private static readonly IDirectoryFeature[]? _directoryFeatures = new IDirectoryFeature[] { };
    private static readonly IFileFeature[]? _fileFeatures = new IFileFeature[] { };

    public static IEnumerable<IDirectoryFeature>? DirectoryFeatures => _directoryFeatures;
    public static IEnumerable<IFileFeature>? FileFeatures => _fileFeatures;
}