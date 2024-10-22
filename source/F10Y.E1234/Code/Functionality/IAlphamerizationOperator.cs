using System;

using R5T.T0132;


namespace F10Y.E1234
{
    [FunctionalityMarker]
    public partial interface IAlphamerizationOperator : IFunctionalityMarker
    {
        public string Get_Alphamerization(string value)
        {
            if(value is null || value == "")
            {
                throw new ArgumentException("Input value was null or empty.");
            }

            var value_length = value.Length;

            if(value_length < 2)
            {
                throw new Exception($"Value '{value}' was too short. Needs to be at least two (2) characters long.");
            }

            var first = Char.ToLowerInvariant(value[0]);
            var last = Char.ToLowerInvariant(value[value_length - 1]);

            var middle = value_length - 2;

            var middle_AsString = middle.ToString();

            var output = $"{first}{middle_AsString}{last}";
            return output;
        }
    }
}
