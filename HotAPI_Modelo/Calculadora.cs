namespace HotAPI_Modelo;

/// <summary>
///  Métodos de uma calculadora
/// </summary>
public class Calculadora : HotAPI {
    /// <summary>
    /// Subtrai dos números
    /// </summary>
    /// <param name="a">parâmetro 1</param>
    /// <param name="b">parâmetro 2</param>
    /// <returns>subtração retornada</returns>
    public int Subtrai(int a, int b = 878) => a - b;
    /// <summary>
    /// Soma dois números
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Soma(int a, int b) => a + b;

    public int Multiplica(int a, int b) => a * b;
    public int Divide(int a, int b) => a / b;

    /// <summary>
    ///  Exemplo retornando um valor da configuração (appsettings.json, cmdline, ...)
    /// </summary>
    /// <returns></returns>
    public int Teste() => Config["Teste"].ToInt();
}