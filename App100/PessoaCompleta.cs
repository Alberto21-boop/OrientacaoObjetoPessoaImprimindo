using App100;
using System.IO;

Pessoa pessoa = new Pessoa();

pessoa.GetNome = Console.ReadLine();
pessoa.GetIdade = int.Parse(Console.ReadLine());
pessoa.GetProfissao = Console.ReadLine();

string[] lines = { "Nome : " + pessoa.GetNome, "Idade : " + pessoa.GetIdade, "Profissão : " + pessoa.GetProfissao };

string docPath = @"C:\Users\Àlberto Barbòsa\Desktop\PastaImprime";

using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
{
    foreach (string line in lines)
        outputFile.WriteLine(line);
}
