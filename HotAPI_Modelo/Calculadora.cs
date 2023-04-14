namespace HotAPI_Modelo;

/// <summary>
///  M�todos de uma calculadora
/// </summary>
public class Calculadora : HotAPI {
    /// <summary>
    /// Subtrai dos n�meros
    /// </summary>
    /// <param name="a">par�metro 1</param>
    /// <param name="b">par�metro 2</param>
    /// <returns>subtra��o retornada</returns>
    public int Subtrai(int a, int b = 878) => a - b;
    /// <summary>
    /// Soma dois n�meros
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Soma(int a, int b) => a + b;

    public int Multiplica(int a, int b) => a * b;
    public int Divide(int a, int b) => a / b;

    /// <summary>
    ///  Exemplo retornando um valor da configura��o (appsettings.json, cmdline, ...)
    /// </summary>
    /// <returns></returns>
    public int Teste() => Config["Teste"].ToInt();
}