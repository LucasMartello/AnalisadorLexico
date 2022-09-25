using AnalisadorLexico.Results;

namespace AnalisadorLexico.Analyzers
{
    public sealed class ReservedTokenAnalyzer : TokenAnalyzer
    {
        private static IEnumerable<Token> _tokens = new List<Token>
        {
            new Token("if", "CMD_IF"),
            new Token("else", "CMD_ELSE"),
            new Token("while", "CMD_WHILE")
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
