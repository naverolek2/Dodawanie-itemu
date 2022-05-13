using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    public class LongSword : Item
    {
        public LongSword()
        {
            name = "Long Sword";

            price = 350;

            AddStat(Stat.AD, 10);
        }

    }
}
