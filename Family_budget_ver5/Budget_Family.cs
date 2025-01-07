using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_budget_ver5
{
    internal class Budget_Family
    {

        public int TypeCost { get; set; }
        public int idNameTypeFamily { get; set; }
        public int idNameCost { get; set; }

        public int PriceCost { get; set; }

        public string DateCost { get; set; }

        public Budget_Family(int typecost, int idnametypefamily, int idnamecost, int pricecost, string datecost)
        {
            TypeCost = typecost;
            idNameTypeFamily = idnametypefamily;
            idNameCost = idnamecost;
            PriceCost = pricecost;
            DateCost = datecost;
        }
    }
}
