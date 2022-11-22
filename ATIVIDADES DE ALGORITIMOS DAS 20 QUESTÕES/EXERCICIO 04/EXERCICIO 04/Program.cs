//EXERCICIO 4.4.4

double s = 0; // salario do funcionario
double a = 8.75;//ajuste salarial
string n = ""; // nome do funcionario
double st = 0; // salario total
double re = 0; // valor do reajuste

Console.WriteLine("Digite o nome do funcionario");
n = Console.ReadLine();
Console.WriteLine("Digite o salario do funcionario");
s = double.Parse(Console.ReadLine());

re= (a/100) * s;
st = re + s;
Console.WriteLine("o salario do funcionario é: " + s);
Console.WriteLine("o salario depois do reajuste é: " + st);

Console.ReadKey();

