namespace BmiCalculator
{
    internal class Program
    {
        static double CalculateBMI(double weight, double height, string unit = "metric")
        {
            if (unit == "metric")
            {
                return weight / (height * height);
            }
            else if (unit == "imperial")
            {
                return 703 * (weight / (height * height));
            }
            else
            {
                Console.WriteLine("Okänd enhet, returnerar 0");
                return 0;
            }
        }
        static void Main(string[] args)
        {
        Console.WriteLine("Välkommen till BMI-kalkylatorn!");
            Console.Write("Ange din vikt: ");
            double weight = Convert.ToDouble(Console.ReadLine());   
            Console.Write("Ange din längd: ");
            double height = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine($"BMI (metriska enheter): {CalculateBMI(weight, height, "metric")}");
           Console.WriteLine("--------------------------------");
            double bmiWithNamedArgs = CalculateBMI(height: height, weight: weight); //väljer ordning själv
            Console.WriteLine($"(annan ordning på height och weight  {bmiWithNamedArgs}");





        }
    }
}
