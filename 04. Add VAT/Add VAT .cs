List<double> line = Console.ReadLine().Split(", ").Select(double.Parse).ToList();

double vat = 0;
double priceToPrint = 0;

for (int i = 0; i < line.Count; i++)
{
    vat = line[i]*0.2;
    priceToPrint = line[i] + vat;
    Console.WriteLine($"{priceToPrint:f2}");
}
