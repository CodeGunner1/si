using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Arreglo3D
    {

        //Atributos
        private int[,,] Y;
        private int f, c, p;
        const int MAXF = 30;
        const int MAXC = 30;
        const int MAXP = 30;

        //Constructor
        public Arreglo3D()
        {
            Y = new int[MAXF, MAXC, MAXP];
            f = 0;
            c = 0;
            p = 0;
        }

        //Metodos
        public void Cargar(int nf, int nc, int np, int a, int b)
        {
            int f1, c1, p1;
            f = nf; c = nc; p = np; //f,c,p son atributos de Y

            Random r = new Random();
            for (p1 = 1; p1 <= p; p1++)
            {
                for (f1 = 1; f1 <= f; f1++)
                {
                    for (c1 = 1; c1 <= c; c1++)
                    {
                        Y[f1, c1, p1] = r.Next(a, b + 1);
                    }
                }
            }

        }
        public string Descargar()
        {
            string s = "";
            int f1, c1, p1;

            for (p1 = 1; p1 <= p; p1++)
            {
                for (f1 = 1; f1 <= f; f1++)
                {
                    for (c1 = 1; c1 <= c; c1++)
                    {
                        s = s + Y[f1, c1, p1] + "\x09"; //"\x09" es TABULADOR "\t"
                    }
                    //respetar el orden de caracteres ascii \r\n
                    s = s + "\r\n";
                    //s = s + "\x0D" + "\x0A";    //"\x0D" es Retorno de Carro(cursor al inicio), "\x0A" es Salto de linea. 
                }
                s = s + "\r\n\n";
            }
            return s;
        }

        //examen
        //ejercicio 3
        public void OrdenarPorColumnasDeCadaProfundidad()
        {
            int f1, c1, p1, i = 0;
            int[] aux = new int[f * p * c];

           
            for (c1 = 1; c1 <= c; c1++)
            {
                for (p1 = 1; p1 <= p; p1++)
                {
                    for (f1 = 1; f1 <= f; f1++)
                    {
                        aux[i++] = Y[f1, c1, p1];
                    }
                }
            }

         
            int n = aux.Length;
            for (int j = 0; j < n - 1; j++)
            {
                for (int k = 0; k < n - 1 - j; k++)
                {
                    if (aux[k] > aux[k + 1])
                    {
                        int temp = aux[k];
                        aux[k] = aux[k + 1];
                        aux[k + 1] = temp;
                    }
                }
            }

            
            i = 0;
            for (c1 = 1; c1 <= c; c1++)
            {
                for (p1 = 1; p1 <= p; p1++)
                {
                    for (f1 = 1; f1 <= f; f1++)
                    {
                        Y[f1, c1, p1] = aux[i++];
                    }
                }
            }
        }





    }
}
