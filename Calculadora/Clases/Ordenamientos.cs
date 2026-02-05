using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Calculadora.Ordenamientos
{
    internal class Ordenamientos
    {
        int[] arreglo;
        public int[] Burbuja(int[] arreglo)
        {
            try
            {
                this.arreglo = arreglo;
                int aux;
                for (int i = 0; i < this.arreglo.Length - 1; i++)
                {
                    for (int j = 0; j < this.arreglo.Length - 1 - i; j++)
                    {
                        if (this.arreglo[j] > this.arreglo[j + 1])
                        {
                            aux = this.arreglo[j];
                            arreglo[j] = this.arreglo[j + 1];
                            arreglo[j + 1] = aux;
                        }
                    }
                }




                return arreglo;

            }
            catch (Exception ex)
            {
                throw;
                return null;

            }
        }

    }
}
