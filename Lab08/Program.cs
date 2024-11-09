using System.Text;
using System.Text.RegularExpressions;


string text =
    ("That's all, 368 3212" +
    " They buried a good person 841-4874 Returned forever to the bosom of the alooo earth 7928385." +
    " aplleda really 427182098?" +
    " were placed in a cramped 218-381 house nall his worries all hopes 270-2622");


string pattern = @"\b\d{3}[-\s]?\d{4}\b";

Regex regex = new Regex(pattern);

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine($"Аналіз тексту: {text}");
Console.WriteLine();
Console.WriteLine($"Кількість знайдених номерів: {regex.Count(text)}");


MatchCollection matches = regex.Matches(text);
foreach (Match match in matches)
{

    Console.WriteLine($"Знайдений номер: {match.Value} Індекс входження: {match.Index}");
}
