using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class AutoUrbano : Auto
    {
        private string familiar;
        private string taxi;

        public string Familiar
        {
            get { return familiar; }
            set
            {
                familiar = value;
            }
        }

        public string Taxi
        {
            get { return taxi; }
            set
            {
                taxi = value;
            }
        }
    }
}
