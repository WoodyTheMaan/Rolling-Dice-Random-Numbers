using Making_A_Die_Class;

namespace Rolling_Dice_Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Console.WriteLine("Click enter to roll the first Die");
            Thread.Sleep(1000);
            Console.ReadLine();
            Console.WriteLine($"You rolled a {die1}");
            die1.DrawDie();
            Thread.Sleep(5000);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(""); 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.WriteLine("Now click enter to roll the second Die");
            Thread.Sleep(1000);
            Console.ReadLine();
            Console.WriteLine($"You rolled a {die2}");
            die2.DrawDie();
            Console.WriteLine("Clcik enter twice real fast to leave");
            Console.ReadLine();
        }
    }
}