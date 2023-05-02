using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3
{
    public abstract class Currency
    {
        protected double rate;

        public Currency(double rate)
        {
            this.rate = rate;
        }

        public abstract double ConvertToRuble(double amount);

        public virtual void PrintAmount(double amount)
        {
            MessageBox.Show($"Amount: {amount}");
        }
    }
}

