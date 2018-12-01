using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08Lib
{
    public class Sub
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string PhoneNum { get; set; }
        public string Country { get; set; }
        private int cost;
        public int Cost
        {
            get { return cost; }
            set
            {
                if (value<1 && value > 300)
                {
                    throw new InvalidCostException();
                }
                else
                {
                    cost = value;
                }
            }
        }
        public bool HasCost { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}.  Номер телефона абонента:{2}.  {3}.  Стоимость пакета услуг:{4}({5})\r\n", Name, SecondName, PhoneNum, Country, Cost, HasCost ? "Тариф оплачен" : "Тариф не оплачен");

        }

    }
}
