namespace LibraryCalc14.Contracts
{
    public interface ICalculadora
    {
        /// <summary>
        /// Realizar a soma de 2 valores
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <returns></returns>
        decimal Somar(decimal valor1, decimal valor2);

        /// <summary>
        /// Realizar a soma de 3 valores
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <param name="valor3">Informar o valor 3</param>
        /// <returns></returns>
        decimal Somar(decimal valor1, decimal valor2, decimal valor3);

        /// <summary>
        /// Realizar a subtração de 2 valores
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <returns></returns>
        decimal Subtrair(decimal valor1, decimal valor2);

        /// <summary>
        /// Realizar a subtração de 3 valores
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <param name="valor3">Informar o valor 3</param> 
        /// <returns></returns>
        decimal Subtrair(decimal valor1, decimal valor2, decimal valor3);

        /// <summary>
        /// Realizar a divisão de 2 valores
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <returns></returns>
        decimal Dividir(decimal valor1, decimal valor2);

        /// <summary>
        /// Realizar a multiplição de 2 valores
        /// </summary>
        /// <param name="valor1">Informar o valor 1</param>
        /// <param name="valor2">Informar o valor 2</param>
        /// <returns></returns>
        decimal Multiplicar(decimal valor1, decimal valor2);        
    }
}
