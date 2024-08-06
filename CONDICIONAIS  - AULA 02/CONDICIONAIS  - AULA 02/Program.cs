// See https://aka.ms/new-console-template for more information
Console.Title = "Nome da instituição";

Console.WriteLine("Hello, Info07M!");

String nome;
String Disciplina;
Double nota1, nota2, nota3, média;

Console.WriteLine("Digite o nome do aluno: ");
nome = Console.ReadLine();

Console.WriteLine("Digite o nome da disciplina: ");
Disciplina = Console.ReadLine();

Console.WriteLine("Digite a nota1 do aluno: ");
nota1 = Double.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota2 do aluno: ");
nota2 = Double.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota3 do aluno: ");
nota3 = Double.Parse(Console.ReadLine());

média = (nota1 + nota2 + nota3) / 3;



Console.WriteLine("Aguarde.....," + nome);

Console.WriteLine("Média Final : " + média);

if(média > 6)
{
    Console.WriteLine("Aprovado!!!");
}
else if (média == 6)
{
    Console.WriteLine("Aprovado na média");
}
else
{
    Console.WriteLine("Reprovado!!!");

}