using LibraryCalc14.Contracts;

namespace LibraryCalc14
{
    public class Calculadora : ICalculadora
    {
        /// <summary>
        /// Implementação da Soma
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <returns></returns>
        public decimal Somar(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }

        /// <summary>
        /// Implementação da soma com 3 valores
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <param name="valor3">Informar o valor 3</param>
        /// <returns></returns>
        public decimal Somar(decimal valor1, decimal valor2, decimal valor3)
        {
            return valor1 + valor2 + valor3;
        }

        /// <summary>
        /// Implementação da Subtração
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <returns></returns>
        public decimal Subtrair(decimal valor1, decimal valor2)
        {
            return valor1 - valor2;
        }

        /// <summary>
        /// Implementação da Subtração com 3 valores
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <param name="valor3">Informar o valor 3</param>
        /// <returns></returns>
        public decimal Subtrair(decimal valor1, decimal valor2, decimal valor3)
        {
            return valor1 - valor2 - valor3;
        }

        /// <summary>
        /// Implementação da Divisão
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <returns></returns>
        public decimal Dividir(decimal valor1, decimal valor2)
        {
            return valor1 / valor2;
        }

        /// <summary>
        /// Implementação da Multiplicação
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <returns></returns>
        public decimal Multiplicar(decimal valor1, decimal valor2)
        {
            return valor1 * valor2;
        }        
    }
}
