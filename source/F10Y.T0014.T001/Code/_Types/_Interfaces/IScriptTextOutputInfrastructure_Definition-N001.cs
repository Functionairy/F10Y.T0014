using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.T0014.T001.N001
{
    /// <summary>
    /// Contains properties and methods for writing text to a file, then opening that text file, as part of a script.
    /// </summary>
    [UtilityTypeMarker]
    public interface IScriptTextOutputInfrastructure_Definition
    {
        /// <summary>
        /// Provides a path for writing output text.
        /// </summary>
        protected string Output_TextFilePath { get; }

        /// <summary>
        /// Provides the ability open files for display.
        /// </summary>
        /// <remarks>
        /// This would typically be a text editor like notepad, Notepad++, or VS Code.
        /// </remarks>
        protected void Open_FilePaths(params string[] filePaths);

        protected void Open_FilePath(string filepath)
            => this.Open_FilePaths(filepath);

        protected void Open(string filePath)
            => this.Open_FilePath(filePath);

        /// <summary>
        /// Provides the ability open directories for display.
        /// </summary>
        /// <remarks>
        /// This would typically be a file explorer, like Windows Explorer.
        /// </remarks>
        protected void Open_DirectoryPaths(params string[] directoryPaths);

        protected void Open_DirectoryPath(string directoryPath)
            => this.Open_DirectoryPaths(directoryPath);

        /// <summary>
        /// Opens the <see cref="Output_TextFilePath"/>.
        /// </summary>
        protected void Open_OutputTextFile()
            => this.Open_FilePaths(
                this.Output_TextFilePath);

        protected Task Write_Lines(
            string filePath,
            IEnumerable<string> lines)
            => Instances.FileOperator.Write_Lines(
                filePath,
                lines);

        protected Task Write_Lines(IEnumerable<string> lines)
            => this.Write_Lines(
                this.Output_TextFilePath,
                lines);

        protected async Task Write_Lines_AndOpen(IEnumerable<string> lines)
        {
            await this.Write_Lines(lines);

            this.Open_OutputTextFile();
        }

        protected async Task Write_Lines_AndOpen(
            string filePath,
            IEnumerable<string> lines)
        {
            await Instances.FileOperator.Write_Lines(
                filePath,
                lines);

            this.Open_FilePaths(filePath);
        }
    }
}
