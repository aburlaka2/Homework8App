using System;
using Homework8App.CardSystem.Interfaces;

namespace Homework8App.CardSystem.Specific
{
    public class PlatinumCard : CommonCard, ICashWihdrawl, ICashDeposit
    {
        public PlatinumCard(string number, CardSecurity security, DateTime expirationDate, Customer owner, Bank emittent)
            : base(number, security, expirationDate, owner, emittent)
        {
        }

        public decimal AtmWithdraw()
        {
            throw new NotImplementedException();
        }

        public override decimal DepositCommission(decimal amount)
        {
            if (amount > 10_000)
            {
                return base.DepositCommission(amount) / 2;
            }
            else
            {
                return base.DepositCommission(amount) + 15;
            }
        }

        public override decimal WithdrawCommission(decimal amount)
        {
            return 20;
        }
    }
}