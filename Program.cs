using Strategy;

Aritmetica calculo1 = new Aritmetica();

Disciplina d = new Disciplina(calculo1, 10, 10)
{
    Nome = "Padroes de Desenvolvimento",
};

d.CalcularMedia();
Console.WriteLine($"Médiaa {calculo1.TipoDeMedia}");
Console.WriteLine("-----------------------------");
Console.WriteLine(d.Nome);
Console.WriteLine($"P1: {d.P1}\nP2: {d.P2}\n{d.Media}\n{d.Situacao}");
Console.WriteLine("----------------------------\n\n");

Geometrica calculo2 = new Geometrica();
d.CalcMedia = calculo2;
d.CalcularMedia();
Console.WriteLine($"Média {calculo2.TipoDeMedia}");
Console.WriteLine("-----------------------------");
Console.WriteLine(d.Nome);
Console.WriteLine($"P1: {d.P1}\nP2: {d.P2}\n{d.Media.ToString("F")}\n{d.Situacao}");
Console.WriteLine("-----------------------------\n\n");






