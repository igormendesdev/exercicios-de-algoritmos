// EXERCICIO 4.4.3

double vu = 0; //valor unitario
double vt = 0; //valor total
double qt= 0; //quantitade
string nome, cod; //nome e codigo


Console.WriteLine("Digite o codigo do produto");
cod = Console.ReadLine();
Console.WriteLine("Digite o nome do produto");
nome = Console.ReadLine();
Console.WriteLine("Digite a quantidade comprada");
qt = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor unitario");
vu = double.Parse(Console.ReadLine());

vt = qt * vu;
Console.WriteLine("");

Console.WriteLine("Codigo do produto -  " + cod);
Console.WriteLine("Nome do produto - " + nome);
Console.WriteLine("Quantidade comprada - " + qt);
Console.WriteLine("Valor unitario do produto -  " + vu);
Console.WriteLine("Valor total da venda - " + vt);

Console.ReadKey();

