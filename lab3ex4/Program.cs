namespace lab1ex1
{
    /*
     Scrieti un program care va afisa semnul unui numar citit de la tastatura
    • Daca numarul este pozitiv, va afisa “+”
    • Daca numarul este negativ, va afisa “-”
    • Daca numarul este 0, va afisa “0”
     */
    class Program
    {
        private const string Value = "-";

        static void Main(string[] args)
        {
            double numar = Convert.ToDouble(Console.ReadLine());  
            if(numar == 0)
            {
                Console.WriteLine("0");
            }
            if (numar > 0) {
                Console.WriteLine("+");
            }if (numar < 0) {
                Console.WriteLine("-");
            }
        }
    }
}