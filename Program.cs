//Calcule a área de um triângulo qualquer, dadas as medidas dos 3 lados. Exiba o semiperímetro e a área.
Console.WriteLine("DIGITE O LADO A:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("DIGITE O LADO B:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("DIGITE O LADO C:");
double c = Convert.ToDouble(Console.ReadLine());

double P = (a + b + c) / 2;
double area = Math.Sqrt((P * (P - a) * (P - b) * (P - c)));
Console.WriteLine($"seu semiperimetro é: {P}");
Console.WriteLine($"A ARÉA DO SEU TRIANGULO É: {area}");