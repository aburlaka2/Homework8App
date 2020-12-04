
using System;
using System.Collections.Generic;
using System.Text;
using Homework8App.CardSystem.Interfaces;

namespace Homework8App
{
    public class Atm
    {
        public decimal Withdraw(ICashWihdrawl card)
        {
            return card.AtmWithdraw();
        }
        public decimal Deposit(ICashDeposit card)
        {
            return card.AtmDeposit();
        }
    }
}