using AnalisadorLexico.Analyzers;

var analyzers = new List<TokenAnalyzer>
{
    new AttributionTokenAnalyzer(),
    new ReservedTokenAnalyzer(),
    new NumbersTokenAnalyzer(),
    new OperatorsTokenAnalyzer(),
    new DelimiterTokenAnalyzer(),    
    new IdentifiersTokenAnalyzer()
    //adicionar os outros analyzers
};

Console.WriteLine("Digite uma string de entrada (use espaco para separar os lexemas):");
Console.WriteLine();

//descomentar a linha abaixo e remover a linha onde seta entradas como uma string fixa
//var entradas = Console.ReadLine().Split(' ');
var entradas = "while ( a < v + 4 ) { total = soma + 1 }".Split(' ');

foreach (var entrada in entradas)
{
    foreach (var analyzer in analyzers)
    {
        var result = analyzer.Test(entrada);

        if (result != null)
        {
            Console.WriteLine($"'{result.Lexeme}' -> {result.Token}");
            break;
        }
    }
}


Console.ReadKey();