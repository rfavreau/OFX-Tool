﻿using RFD.OFXTool.Library.Attributes;

namespace RFD.OFXTool.Library.Entities
{
    public abstract class AbstractBalance
    {
        //
        // Résumé :
        //     Gets or sets the available balance amount.
        [Element("BALAMT")]
        public string? BalanceAmount { get; set; }
        //
        // Résumé :
        //     Gets or sets the balance date.
        [Element("DTASOF")]
        public string? DateAsOf { get; set; }

        // Determines whether the specified object is equal to the current object.
        public override bool Equals(object? obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                AbstractBalance e = (AbstractBalance)obj;
                return Entity.PropertyEquality(e.BalanceAmount, BalanceAmount) &&
                    Entity.PropertyEquality(e.DateAsOf, DateAsOf);
            }
        }

        //Serves as the default hash function
        public override int GetHashCode() => new { BalanceAmount, DateAsOf }.GetHashCode();
    }
}
