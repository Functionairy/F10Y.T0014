using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.T0014.T001.N002
{
    /// <summary>
    /// In addition to the abilities of <see cref="N001.IScriptTextOutputInfrastructure_Definition"/>, contains methods to copy to the syatem clipboard.
    /// </summary>
    [UtilityTypeMarker]
    public interface IScriptTextOutputInfrastructure_Definition :
        N001.IScriptTextOutputInfrastructure_Definition
    {
        protected Task Copy_ToClipboard(string text);
        protected void Copy_ToClipboard_Synchronous(string text);
    }
}
