using System;

using F10Y.T0003;


namespace F10Y.T0014.T004
{
    [ValuesMarker]
    public partial interface IFilePaths
    {
        /// <summary>
        /// Switches on operating system between:
        /// <list type="bullet">
        /// <item><inheritdoc cref="Output_TextFilePath_Windows" path="descendant::value"/> (<see cref="Output_TextFilePath_Windows"/>)</item>
        /// <item><inheritdoc cref="Output_TextFilePath_NonWindows" path="descendant::value"/> (<see cref="Output_TextFilePath_NonWindows"/>)</item>
        /// </list>
        /// </summary>
        string Output_TextFilePath => Instances.OperatingSystemOperator.SwitchOn_OSPlatform(
            () => this.Output_TextFilePath_Windows,
            () => this.Output_TextFilePath_NonWindows);

        /// <summary>
        /// <para><value>C:\Temp\Output.txt</value></para>
        /// </summary>
        string Output_TextFilePath_Windows => @"C:\Temp\Output.txt";

        /// <summary>
        /// <para><value>{%USER_PROFILE%}\Output.txt</value></para>
        /// </summary>
        string Output_TextFilePath_NonWindows => Instances.PathOperator.Get_FilePath(
            Instances.DirectoryPaths.User,
            "Output.txt");
    }
}
