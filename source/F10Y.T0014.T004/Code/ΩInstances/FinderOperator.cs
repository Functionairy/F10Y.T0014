using System;


namespace F10Y.T0014.T004
{
    public class FinderOperator : IFinderOperator
    {
        #region Infrastructure

        public static IFinderOperator Instance { get; } = new FinderOperator();


        private FinderOperator()
        {
        }

        #endregion
    }
}
