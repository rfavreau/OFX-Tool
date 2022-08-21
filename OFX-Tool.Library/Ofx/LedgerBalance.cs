﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFD.OFXTool.Library.Ofx
{
    public class LedgerBalance
    {
        //
        // Résumé :
        //     Gets or sets the ledger balance amount.
        public string? BalanceAmount { get; set; }
        //
        // Résumé :
        //     Gets or sets the balance date.
        public string? DateAsOf { get; set; }

        // Determines whether the specified object is equal to the current object.
        public override bool Equals(Object? obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                LedgerBalance e = (LedgerBalance)obj;
                return Entity.PropertyEquality(e.BalanceAmount, BalanceAmount) &&
                    Entity.PropertyEquality(e.DateAsOf, DateAsOf);
            }
        }

        //Serves as the default hash function
        public override int GetHashCode() => new { BalanceAmount, DateAsOf }.GetHashCode();
    }
}
