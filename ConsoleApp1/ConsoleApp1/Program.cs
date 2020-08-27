using System;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            PiggyBank acc = new PiggyBank();
            balanceLogger bl = new balanceLogger();
            balanceWatcher bw = new balanceWatcher();

            acc.currBalanceUpdate += bl.printBalance;
            acc.currBalanceUpdate += bw.printBalance;

            int dep = 0;

            while (true)
            {
                Console.WriteLine("How much to deposit?");
                string val = Console.ReadLine();
                if (val.Trim().ToLower() == "exit")
                    break;

                int.TryParse(val, out dep);
                acc.deposit(dep);

                

            }



        }

    }


}
