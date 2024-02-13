namespace Heltalsdivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double resultat;
            int restDel;

            Console.Write("Indtast dit første tal: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Indtast dit andet tal: ");
            b = int.Parse(Console.ReadLine());

            resultat = a / b;
            restDel = a % b;
            Console.WriteLine("Dit resultat er: " + resultat + "\nDin restdel er: " + restDel);



        }
    }
}