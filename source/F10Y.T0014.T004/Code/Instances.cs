using System;


namespace F10Y.T0014.T004
{
    public static class Instances
    {
        public static L0020.ICommandLineOperator CommandLineOperator => L0020.CommandLineOperator.Instance;
        public static L0000.IConsoleOperator ConsoleOperator => L0000.ConsoleOperator.Instance;
        public static L0000.IDirectoryPaths DirectoryPaths => L0000.DirectoryPaths.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static IFilePaths FilePaths => T004.FilePaths.Instance;
        public static IFinderOperator FinderOperator => T004.FinderOperator.Instance;
        public static L0019.INotepadPlusPlusOperator NotepadPlusPlusOperator => L0019.NotepadPlusPlusOperator.Instance;
        public static L0000.IOperatingSystemOperator OperatingSystemOperator => L0000.OperatingSystemOperator.Instance;
        public static L0000.IPathOperator PathOperator => L0000.PathOperator.Instance;
        public static L0034.IVisualStudioCodeOperator VisualStudioCodeOperator => L0034.VisualStudioCodeOperator.Instance;
        public static L0032.IWindowsExplorerOperator WindowsExplorerOperator => L0032.WindowsExplorerOperator.Instance;
    }
}