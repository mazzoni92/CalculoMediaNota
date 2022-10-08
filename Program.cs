//Calculadora de Media V1
double nota1 = 0;
double nota2 = 0;
double nota3 = 0;
double nota4 = 0;
double nota5 = 0;
double media = 0;

Console.WriteLine("Digite a nota do primeiro aluno");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a nota do segundo aluno");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a nota do terceiro aluno");
nota3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a nota do quarto aluno");
nota4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a nota do quinto aluno");
nota5 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

Console.WriteLine($"A media das 5 notas são: {media}");
