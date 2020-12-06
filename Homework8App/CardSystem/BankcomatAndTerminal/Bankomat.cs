using System;
using System.Collections.Generic;
using System.Text;
using Homework8App.CardSystem.Interfaces;
using Homework8App.CardSystem.Specific;

namespace Homework8App.CardSystem.BankcomatAndTerminal
{
    class Bankomat: ICashWihdrawl
    {
        public decimal AtmWithdraw()
        {
            throw new NotImplementedException();
        }
        public void EnterPin(int CardNumber, int sequrity)
        {
            bool check = false;
            while(check==false)
            {
                Console.WriteLine("Enter your pin");
                check = int.TryParse(Console.ReadLine(), out int codeenter);
                if (check)
                {
                    BankomatMenu();
                }
                else
                {
                    Console.WriteLine("You enter wrong code. Try again");
                    check = false;
                }
            }

        }
        public void BankomatMenu()
        {
            Console.WriteLine("Choose option");
            Console.WriteLine("");
            Console.WriteLine("1 - Ballace");
            Console.WriteLine("");
            Console.WriteLine("2 - Get Cash");
            Console.WriteLine("");
            Console.WriteLine("3 - Exit");
            decimal ballance = CommonCard.Balance;
            bool choose = false;
            while (choose == false)
            {
                Console.WriteLine("Enter your pin");
                choose = int.TryParse(Console.ReadLine(), out int chooseOption);
                if (choose)
                {
                    if (chooseOption == 1)
                    {
                        Balance(ballance);
                    }
                    else if (chooseOption == 2)
                    {
                        GetCash();
                    }
                    else if (chooseOption == 3)
                        Console.WriteLine("You leave the bankomat");
                }
            }

        }
        public void Balance(decimal ballance)
        {
            Console.WriteLine("Your ballance is");
            Console.WriteLine(ballance);
        }
    }
}
