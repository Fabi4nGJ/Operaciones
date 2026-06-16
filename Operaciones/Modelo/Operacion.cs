using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones.Modelo
{
    public class operaciones
    {
        // Genera una lista de números en un rango dado, filtrando por pares o impares
        public List<int> GenerarRango(int inicio, int fin, bool esPar)
        {
            List<int> numeros = new List<int>();
            for (int i = inicio; i <= fin; i++)
            {
                if (esPar && i % 2 == 0)
                {
                    numeros.Add(i);
                } else if (!esPar && i % 2 != 0)
                {
                    numeros.Add(i);
                }
            }
            return numeros;
        }

        // Métodos para las operaciones matemáticas
        public int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Restar(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

    }

}
