﻿using System;
using Homework8App.CardSystem.Interfaces;

namespace Homework8App.CardSystem.Specific
{
    public class SavingsCard : CommonCard, ICashDeposit
    {
        public SavingsCard(string number, CardSecurity security, DateTime expirationDate, Customer owner, Bank emittent)
            : base(number, security, expirationDate, owner, emittent)
        {
            WithdrawCommissionPercent = 0.02m;
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
