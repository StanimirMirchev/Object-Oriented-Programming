using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate decimal CalculateInterest(decimal sum, decimal interest, int years);
    public class InterestCalculator
    {
        private decimal money;
        private decimal interes;
        private CalculateInterest type;
        private int years;

        public InterestCalculator(decimal money, decimal interes, int years, CalculateInterest type)
        {
            this.years = years;
            this.type = type;
            this.interes = interes;
            this.money = money;
        }

        public override string ToString()
        {
            return string.Format("{0:F4}", this.type(this.money, this.interes, this.years));
        }
    }
}
