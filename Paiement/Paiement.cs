﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paiement
{
    public abstract class Paiement
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public abstract void DisplayDetails();
    }
}
