//EXERCICIO 4.4.2

double n1, n2, n3 = 0;
double t = 0;
double m = 0;


Console.WriteLine("Digite 03 numeros para saber a media entre eles: ");
n1 = Convert.ToDouble(Console.ReadLine());
n2 = Convert.ToDouble(Console.ReadLine());
n3 = Convert.ToDouble(Console.ReadLine());

t = n1 + n2 + n3;
m = t / 3;
Console.WriteLine("Essa e media dos numeros " + m);
Console.ReadKey();