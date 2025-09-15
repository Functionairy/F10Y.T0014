using System;

using F10Y.T0004;


namespace F10Y.T0014.T002
{
    /// <summary>
    /// Contains properties and methods for writing text to a file, then opening that text file, as part of a script.
    /// </summary>
    [UtilityTypeMarker]
    public interface IScriptTextOutputInfrastructure_Implementation :
        T001.IScriptTextOutputInfrastructure_Definition
    {
        string T001.N001.IScriptTextOutputInfrastructure_Definition.Output_TextFilePath =>
            Instances.FilePaths.Output_TextFilePath;

        void T001.N001.IScriptTextOutputInfrastructure_Definition.Open_FilePaths(params string[] filePaths)
            => Instances.NotepadPlusPlusOperator.Open(filePaths);

        void T001.N001.IScriptTextOutputInfrastructure_Definition.Open_DirectoryPaths(params string[] directoryPaths)
            => Instances.WindowsExplorerOperator.Open_Directories_InExplorer(directoryPaths);
    }
}
