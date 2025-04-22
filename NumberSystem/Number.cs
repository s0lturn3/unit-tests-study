using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem
{
    public class Number
    {

        int num;
        public Guid genericGuid;

        public Number(int num)
        {
            this.num = num;
            this.genericGuid = Guid.NewGuid();
        }

        public String evenAndOdd()
        {
            return num % 2 == 0 ? "EVEN" : "ODD";
        }

    }
}
