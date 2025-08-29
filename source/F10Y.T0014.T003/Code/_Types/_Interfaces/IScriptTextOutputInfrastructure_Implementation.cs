using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.T0014.T003
{
    /// <summary>
    /// Contains properties and methods for writing text to a file, then opening that text file, as part of a script.
    /// </summary>
    [UtilityTypeMarker]
    public interface IScriptTextOutputInfrastructure_Implementation :
        T002.IScriptTextOutputInfrastructure_Implementation,
        T001.N002.IScriptTextOutputInfrastructure_Definition
    {
        Task T001.N002.IScriptTextOutputInfrastructure_Definition.Copy_ToClipboard(string text)
            => Instances.ClipboardOperator.Copy_ToClipboard(text);

        void T001.N002.IScriptTextOutputInfrastructure_Definition.Copy_ToClipboard_Synchronous(string text)
            => Instances.ClipboardOperator.Copy_ToClipboard_Synchronous(text);
    }
}
