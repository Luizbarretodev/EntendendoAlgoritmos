using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EntendendoAlgoritmos.Core.Capitulo01;

namespace EntendendoAlgoritmos.Tests.Capitulo01;

public class PesquisaBinariaTests
{
    [Fact]
    public void Deve_Retornar_Indice_Do_Elemento_Quando_Indice_Existir()
    {
        int[] minhaLista = [1, 3, 5, 7, 9, 11, 15];
        int numeroProcurado = 7;


        int? resultado = PesquisaBinaria.Buscar(minhaLista, numeroProcurado);

        Assert.Equal(3, resultado);
    }

    [Fact]
    public void Deve_Retornar_Null_Quando_Nao_Existir()
    {
        int[] minhaLista = [2, 4, 6, 8, 10];
        int numeroProcurado = 5; 


        int? resultado = PesquisaBinaria.Buscar(minhaLista, numeroProcurado);


        Assert.Null(resultado);
    }
}