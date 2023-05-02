using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3
{
    public class Dollar : Currency
    {
        public Dollar(double rate) : base(rate)
        {
        }

        public override double ConvertToRuble(double amount)
        {
            return amount * rate;
        }

        public override void PrintAmount(double amount)
        {
            MessageBox.Show($"Amount in dollars: {amount}\nAmount in rubles: {ConvertToRuble(amount)}");
        }
    }

}
