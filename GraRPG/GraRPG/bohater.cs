using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
    abstract class bohater
    {
        public string imie;
        public int zywotnosc;

        public void zmianaZywotnosci(int hp)
        {
            if(hp > 100)
            {
                this.zywotnosc = 100;
            }
            if(hp < 0)
            {
                this.zywotnosc = 0;
            }
        }
    }
}
