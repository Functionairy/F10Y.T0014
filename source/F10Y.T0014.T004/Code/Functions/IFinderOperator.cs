using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.T0014.T004
{
    [FunctionsMarker]
    public partial interface IFinderOperator
    {
        void Open_Directory_InExplorer(string directoryPath)
        {
            var arguments = $"\"{directoryPath}\"";

            Instances.CommandLineOperator.Run_Synchronous(
                "open",
                arguments);
        }

        void Open_Directories_InExplorer(IEnumerable<string> directoryPaths)
        {
            foreach (var directoryPath in directoryPaths)
            {
                this.Open_Directory_InExplorer(directoryPath);
            }
        }

        void Open_Directories_InExplorer(params string[] directoryPaths)
        {
            this.Open_Directories_InExplorer(directoryPaths.AsEnumerable());
        }
    }
}
