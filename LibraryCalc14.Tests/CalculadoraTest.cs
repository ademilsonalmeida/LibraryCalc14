using Xunit;

namespace LibraryCalc14.Tests
{
    public class CalculadoraTest
    {
        Calculadora calculadora = new Calculadora();

        #region Testes Soma
        [Fact]
        public void SomaSucesso()
        {
            var valor1 = 10;
            var valor2 = 5;

            var resultado = calculadora.Somar(valor1, valor2);

            Assert.True((valor1 + valor2) == resultado);
        }

        [Fact]
        public void SomaErro()
        {
            var valor1 = 10;
            var valor2 = 5;

            var resultado = calculadora.Somar(valor1, valor2);

            Assert.False((valor1 + valor2) != resultado);
        }

        [Theory]
        [InlineData(10, 3, 7)]
        public void Soma3ValoresSucesso(decimal valor1, decimal valor2, decimal valor3)
        {
            var resultado = calculadora.Somar(valor1, valor2, valor3);

            Assert.True((valor1 + valor2 + valor3) == resultado);
        }
        #endregion

        #region Testes Subtracao
        [Theory]
        [InlineData(10, 5)]
        [InlineData(8, 4)]
        public void SubtracaoSucesso(decimal valor1, decimal valor2)
        {
            var resultado = calculadora.Subtrair(valor1, valor2);

            Assert.True((valor1 - valor2) == resultado);
        }
        #endregion

        #region Testes Divisão
        [Fact]
        public void DivisaoSucesso()
        {
            var valor1 = 10;
            var valor2 = 5;

            var resultado = calculadora.Dividir(valor1, valor2);

            Assert.True((valor1 / valor2) == resultado);
        }
        #endregion

        #region Testes Multiplicação
        [Theory]
        [InlineData(10, 5)]
        [InlineData(8, 4)]
        public void MultiplicacaoSucesso(decimal valor1, decimal valor2)
        {
            var resultado = calculadora.Multiplicar(valor1, valor2);

            Assert.True((valor1 * valor2) == resultado);
        }
        #endregion
    }
}
