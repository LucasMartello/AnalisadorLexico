using AnalisadorLexico.Results;

namespace AnalisadorLexico.Analyzers
{
    public sealed class AttributionTokenAnalyzer : TokenAnalyzer
    {
        private static IEnumerable<Token> _tokens = new List<Token>
        {
            new Token("=", "ATTRIB")
        };

        public override TokenResult Test(string lexeme)
        {
            foreach (var token in _tokens)
            {
                if (lexeme.Equals(token.Operator))
                    return new TokenResult(lexeme, token.Id);
            }

            return null;
        }
    }
}