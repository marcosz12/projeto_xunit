using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace PROJETO_XUNIT
{
    public class TesteCalculadora
    {
        [Fact]
        public void TestarSomar()
        {
            //Given


            //When
            double resultado = Calculadora.Somar(57, 22);

            //Then
            Assert.Equal(79, resultado);
        }

        [Fact]
        public void TestarSubtracao()
        {
            //Given


            //When
            double resultado = Calculadora.Subtrair(57, 22);

            //Then
            Assert.Equal(35, resultado);
        }

        [Fact]
        public void TestarDividir()
        {
            //Given


            //When
            double resultado = Calculadora.Dividir(25, 5);

            //Then
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void TestarMultiplicacao()
        {
            //Given


            //When
            double resultado = Calculadora.Multiplicar(4, 2);

            //Then
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void TestarInfito()
        {
            //Given


            //When
            double resultado = Calculadora.Dividir(2, 0);

            //Then
            Assert.Equal(double.PositiveInfinity, resultado);
        }
    }
}
