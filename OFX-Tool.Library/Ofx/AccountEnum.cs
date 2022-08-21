﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFD.OFXTool.Library.Ofx
{
    public enum AccountEnum
    {
        //
        // Résumé :
        //     Checking type
        CHECKING = 0,
        //
        // Résumé :
        //     Savings Type
        SAVINGS = 1,
        //
        // Résumé :
        //     Money Market Type
        MONEYMRKT = 2,
        //
        // Résumé :
        //     Line of credit Type
        CREDITLINE = 3,
        //
        // Résumé :
        //     Certificate of Deposit Type
        CD = 4
    }
}