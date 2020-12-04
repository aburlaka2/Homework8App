using System;
using System.Collections.Generic;
using System.Text;
using Homework8App.CardSystem.Interfaces;

namespace Homework8App.CardSystem.Specific
{
    class UniversalCard:CommonCard, ICashDeposit
    {
        public UniversalCard(string number, CardSecurity security, DateTime expirationDate, Customer owner, Bank emittent)
           : base(number, security, expirationDate, owner, emittent)
        {
            WithdrawCommissionPercent = 0.04m;
        }

        public override decimal DepositCommission(decimal amount)
        {
            return 0;
        }

        public override decimal WithdrawCommission(decimal amount)
        {
            return amount * 0.005m;
        }
    }
}
