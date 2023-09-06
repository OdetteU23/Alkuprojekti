namespace harjoitus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuinka monta lukua?");
            int luvut = Convert.ToInt32(Console.ReadLine());

            double[] numerot = new double[luvut];

            for (int i = 0; i < luvut; i++)
            {
                Console.WriteLine("Anna luku " + (i + 1) + ": ");
                numerot[i] = Convert.ToDouble(Console.ReadLine());
            }

            double summa = 0;
            foreach (double num in numerot)
            {
                summa += num;
            }

            double keskiarvo = summa / luvut;

            Console.WriteLine("Lukuja oli: " + luvut);
            Console.WriteLine("Lukujen keskiarvo on: " + keskiarvo.ToString());
            Console.WriteLine("Syötetyt luvut olivat: ");
            foreach (double num in numerot)
            {
                Console.WriteLine(num.ToString());
            }
        }
    }
}