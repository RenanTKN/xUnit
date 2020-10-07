using System;
using Xunit;

namespace calculos.tests
{
    public class CalculadoraTest
    {
        Calculadora c;
        public CalculadoraTest()
        {
            c = new Calculadora();
        }

        [Fact]
        public void Soma_DeveRetornarOValorCorreto()
        {
            var resultado = c.Soma(10, 20);
            Assert.Equal(30, resultado);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void RestoDivisao_DeveRetornarZero(int value)
        {
            var resultado = c.RestoDivisao(12, value);
            Assert.Equal(0, resultado.resto);
        }

        [Fact]
        public void RestoDivisao_DeveRetornarOValorCorreto()
        {
            var resultado = c.RestoDivisao(10, 3);
            Assert.Equal(3, resultado.quociente);
            Assert.Equal(1, resultado.resto);
        }

        [Fact]
        public void Subtracao_DeveRetornarOValorCorreto()
        {
            var resultado = c.Subtracao(20, 10);
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Divisao_DeveRetornarOValorCorreto()
        {
            var resultado = c.Divisao(100, 10);
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Multiplicao_DeveRetornarOValorCorreto()
        {
            var resultado = c.Multiplicao(5, 2);
            Assert.Equal(10, resultado);
        }
    }
}
