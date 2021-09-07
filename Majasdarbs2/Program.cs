using System;

namespace Majasdarbs2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// Pirmais uzdevums/////////
            Console.WriteLine("///// Pirmais uzdevums /////");
            Console.WriteLine("Izveidot konsoles aplikāciju, kas pavaicā un  iegūst lietotāja vārdu, un sasveicinās ar konkrēto lietotāju");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Kā tevi sauc?");
            string UserName = Console.ReadLine();
            Console.WriteLine($"\n\nSveiks {UserName}\n\n");
            Console.WriteLine("Nospied jebkuru taustiņu, lai turpinātu");
            Console.ReadKey();
            Console.Clear();

            ///// Otrais uzdevums//////////
            Console.WriteLine("///// Otrais uzdevums /////");
            Console.WriteLine("Iegūst lietotāja vecumu un izvada lietotājam cik gadi viņam paliks nākamgad int.Parse");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Kāds ir tavs vecums?");
            int Age = int.Parse(Console.ReadLine());
            int AgeNextYear = ++Age;
            bool IsAdult = Age >= 18; 
            Console.WriteLine($"\n\nNākamgad tev paliks {AgeNextYear} gadi, tu esi pilngadīgs: {IsAdult}\n\n");
            Console.WriteLine("Nospied jebkuru taustiņu, lai turpinātu");
            Console.ReadKey();
            Console.Clear();

            ///// Trešais uzdevums/////////
            Console.WriteLine("///// Trešais uzdevums /////");
            Console.WriteLine("Iegūt no lietotāja skaitļus un atrādīt lietotājam lielāko skaitli");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Lūdzu ievadiet pirmo skaitli!");
            int MaxNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lūdzu ievadiet otro skaitli!");
            int MaxNumber2 = int.Parse(Console.ReadLine());
            int LargestNumber = Math.Max(MaxNumber1, MaxNumber2);
            Console.WriteLine($"\n\nTu ievadīji {MaxNumber1} un {MaxNumber2}, lielākais skaitlis ir {LargestNumber}\n\n");
            Console.WriteLine("Nospied jebkuru taustiņu, lai turpinātu");
            Console.ReadKey();
            Console.Clear();

            ///// Ceturtais uzdevums///////
            Console.WriteLine("///// Ceturtais uzdevums /////");
            Console.WriteLine("Iegūt no lietotāja skaitļus un atrādīt lietotājam mazāko skaitli");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Lūdzu ievadiet pirmo skaitli!");
            int MinNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lūdzu ievadiet otro skaitli!");
            int MinNumber2 = int.Parse(Console.ReadLine());
            int SmallestNumber = Math.Min(MinNumber1, MinNumber2);
            Console.WriteLine($"\n\nTu ievadīji {MinNumber1} un {MinNumber2}, mazākais skaitlis ir {SmallestNumber}\n\n");
            Console.WriteLine("Nospied jebkuru taustiņu, lai turpinātu");
            Console.ReadKey();
            Console.Clear();

            ///// Piektais uzdevums///////
            Console.WriteLine("///// Piektais uzdevums /////");
            Console.WriteLine("Iegūt no lietotāja skaitļus un atrādīt dalījuma atlikumu");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Lūdzu ievadiet pirmo skaitli!");
            int RemainNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lūdzu ievadiet otro skaitli!");
            int RemainNumber2 = int.Parse(Console.ReadLine());
            int Remained = RemainNumber1 % RemainNumber2;
            Console.WriteLine($"\n\nTu ievadīji {RemainNumber1} un {RemainNumber2}, Dalījuma atlikums ir {Remained}\n\n");
            Console.WriteLine("Nospied jebkuru taustiņu, lai turpinātu");
            Console.ReadKey();
            Console.Clear();

            ///// Sestais uzdevums///////
            Console.WriteLine("///// Sestais uzdevums /////");
            Console.WriteLine("Iegūt no lietotāja skaitli un parādīt vai lietotājs ievadījis pāra vai nepāra skaitli");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Lūdzu ievadiet jebkādu skaitli!");
            int OddEvenNumber = int.Parse(Console.ReadLine());
            bool IsEven = OddEvenNumber % 2 == 0;
            Console.WriteLine($"\n\n{OddEvenNumber} ir pāra skaitlis: {IsEven}\n\n");
            Console.WriteLine("Nospied jebkuru taustiņu, lai turpinātu");
            Console.ReadKey();
            Console.Clear();

            ///// Septītais uzdevums///////
            Console.WriteLine("///// Septītais uzdevums /////");
            Console.WriteLine($"Iegūt no lietotāja taisnstūra malu vērtības un aprēķināt taisnstūra laukumu. \n Precīzi jāaprēķina laukums arī ja tas sanāk decimāldaļās jānoapaļo ar 2 cipariem aiz komata");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Lūdzu ievadiet taisnstūra pirmās malas garmumu!");
            decimal RectNumber1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Lūdzu ievadiet taisnstūra otrās malas garumu!");
            decimal RectNumber2 = decimal.Parse(Console.ReadLine());
            decimal RectField = decimal.Round(RectNumber1 * RectNumber2, 2);
            Console.WriteLine($"\n\nAprēķinātais taisnstūra laukums ir: {RectField}!\n\n");
            Console.WriteLine("Nospied jebkuru taustiņu, lai turpinātu");
            Console.ReadKey();
            Console.Clear();

            ///// Astotais uzdevums///////
            Console.WriteLine("///// Astotais uzdevums /////");
            Console.WriteLine("Iegūt no lietotāja skaitli, lai aprēķinātu vienādsānu trijstūra laukumu ");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Lūdzu ievadiet vinādsāna trijstūra malas garmumu!");
            float TriangleSide = float.Parse(Console.ReadLine());
            double TriangleArea = (((float)Math.Sqrt(3) / 4) * TriangleSide * TriangleSide);
            Console.WriteLine($"\n\nAprēķinātais vienādsānu trijstūra laukums ir: {TriangleArea}!\n \n");
            Console.WriteLine("Nospied jebkuru taustiņu, lai turpinātu");
            Console.ReadKey();
            Console.Clear();

            ///// Devītais uzdevums/////////
            Console.WriteLine("///// Devītais uzdevums /////");
            Console.WriteLine("Iegūst lietotāja vecumu un izvada lietotājam vārdu un vecumu izmantojot interpolāciju");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Kāds ir tavs vārds?");
            string NameAgain = Console.ReadLine();
            Console.WriteLine("Kāds ir tavs vecums?");
            int AgeAgain = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n\nSveiks {UserName}, tavs vecums ir {AgeAgain}\n \n");
            Console.WriteLine("Nospied jebkuru taustiņu, lai beigtu mājasdarba pārbaudi :).");
            Console.ReadKey();




        }
    }
}
