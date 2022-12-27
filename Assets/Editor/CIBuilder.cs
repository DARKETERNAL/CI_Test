using UnityEditor;
using UnityEditor.Build.Reporting;

public class CIBuilder
{
    [MenuItem("CI Build/Build PC")]
    public static void BuildPC()
    {
        BuildPlayerOptions buildOptions = new();
        buildOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildOptions.locationPathName = "Build/PC/PC.exe";
        buildOptions.target = BuildTarget.StandaloneWindows;
        buildOptions.options = BuildOptions.None;

        BuildReport report = BuildPipeline.BuildPlayer(buildOptions);
    }
}