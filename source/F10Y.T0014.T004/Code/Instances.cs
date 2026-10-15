using System;


namespace F10Y.T0014.T004
{
#pragma warning disable IDE1006 // Naming Styles
    public interface Instances :
#pragma warning restore IDE1006 // Naming Styles
        L0041.Instances_Internal
    {
        public static L0000.IConsoleOperator ConsoleOperator => L0000.ConsoleOperator.Instance;
        public static L0000.IDirectoryPaths DirectoryPaths => L0000.DirectoryPaths.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L0004.L001.IFilePaths FilePaths => L0004.L001.FilePaths.Instance;
        public static L0019.INotepadPlusPlusOperator NotepadPlusPlusOperator => L0019.NotepadPlusPlusOperator.Instance;
        public static L0000.IOperatingSystemOperator OperatingSystemOperator => L0000.OperatingSystemOperator.Instance;
        public static L0000.IPathOperator PathOperator => L0000.PathOperator.Instance;
        public static L0034.IVisualStudioCodeOperator VisualStudioCodeOperator => L0034.VisualStudioCodeOperator.Instance;
        public static L0032.IWindowsExplorerOperator WindowsExplorerOperator => L0032.WindowsExplorerOperator.Instance;
    }
}