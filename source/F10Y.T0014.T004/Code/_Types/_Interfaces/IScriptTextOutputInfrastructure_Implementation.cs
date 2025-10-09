using System;

using F10Y.T0004;


namespace F10Y.T0014.T004
{
    [UtilityTypeMarker]
    public interface IScriptTextOutputInfrastructure_Implementation :
        T001.IScriptTextOutputInfrastructure_Definition
    {
        string T001.N001.IScriptTextOutputInfrastructure_Definition.Output_TextFilePath =>
            Instances.FilePaths.Output_TextFilePath;

        void T001.N001.IScriptTextOutputInfrastructure_Definition.Open_FilePaths(params string[] filePaths)
        {
            Action<string[]> action = Instances.OperatingSystemOperator.SwitchOn_OSPlatform<Action<string[]>>(
                Instances.NotepadPlusPlusOperator.Open,
                Instances.VisualStudioCodeOperator.Open);

            action(filePaths);
        }

        void T001.N001.IScriptTextOutputInfrastructure_Definition.Open_DirectoryPaths(params string[] directoryPaths)
        {
            Action<string[]> action = Instances.OperatingSystemOperator.SwitchOn_OSPlatform<Action<string[]>>(
                Instances.WindowsExplorerOperator.Open_Directories_InExplorer,
                Instances.FinderOperator.Open_Directories_InExplorer);

            action(directoryPaths);
        }
    }
}
