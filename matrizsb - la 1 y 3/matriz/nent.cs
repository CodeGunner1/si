using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class nent
    {
        private int n;
        public nent()
        {
            n = 0;
        }
        public void cargar(int dato)
        {
            n = dato;
        }
        public int descargar()
        {
            return n;
        }

        public bool verif_primo(int ele)
        {
            bool ban = true;
            int c = 2;
            if (ele > 1)
            {
                while (c <= (ele / 2) && (ban == true))
                {
                    if (ele % c == 0)
                    {
                        ban = false;
                    }
                    c++;
                }
            }
            else
            {
                ban = false;
            }

            return ban;
        }
    }
}
