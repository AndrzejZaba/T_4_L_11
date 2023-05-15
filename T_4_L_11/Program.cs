namespace T_4_L_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj liczbę, którą chcesz sprawdzić: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (Math.Abs(number) % 2 > 0) Console.WriteLine($"Liczba {number} jest nieparzysta\n");
                    else Console.WriteLine($"Liczba {number} jest parzysta\n");
                }
                else
                {
                    Console.WriteLine("Podana wartość jest niepoprawna.\n");
                }
            }
            
        }
    }
}