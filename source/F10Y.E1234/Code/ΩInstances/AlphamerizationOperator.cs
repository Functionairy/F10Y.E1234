using System;


namespace F10Y.E1234
{
    public class AlphamerizationOperator : IAlphamerizationOperator
    {
        #region Infrastructure

        public static IAlphamerizationOperator Instance { get; } = new AlphamerizationOperator();


        private AlphamerizationOperator()
        {
        }

        #endregion
    }
}
