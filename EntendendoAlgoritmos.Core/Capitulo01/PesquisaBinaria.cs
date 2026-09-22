using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Core.Capitulo01;

public static class PesquisaBinaria
{
    public static int? Buscar(int[] arr, int item)
    {
        int baixo = 0;
        int alto = arr.Length - 1;

        while (baixo <= alto)
        {
            int meio = (baixo + alto) / 2;
            int chute = arr[meio];

            if (chute == item)
                return meio;

            if (chute > item)
            {
                alto = meio - 1;
            }
            else
            {
                baixo = meio + 1;
            }
        }
        return null;
    }
}