using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class Triceratops : Dinosaurus 
    {

        int vyska;
        public Triceratops(bool zivotnost)
        {
            
        }

        public void ZerZeleninu()
        {

        }

        //Vlastnost výšky, která beze pouze kladné hodnoty
        int Vyska
        {
            get
            {
                return vyska;
            }
            set
            {
                if(value >= 0)
                {
                    vyska = value;
                }
            }
        }
    }
}
