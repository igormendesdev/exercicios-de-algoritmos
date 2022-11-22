// EXERCICIO 4.4.5

string p; // produto
double vp; // valor do produto
double vt; // Valor total do produto
double de = 10; // Desconto


Console.WriteLine("Digite o Produto desejado");
p = Console.ReadLine();
Console.WriteLine("Digite o valor do produto");
vp = Convert.ToDouble(Console.ReadLine());

vt = vp - (vp * (de / 100));

Console.WriteLine("O valor do produto é: R$" + vp);
Console.WriteLine("O valor do produto com 10% de desconto é: R$ " + vt);

Console.ReadKey();