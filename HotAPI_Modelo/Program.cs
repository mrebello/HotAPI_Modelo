using Microsoft.Extensions.Hosting.Internal;

namespace HotAPI_Modelo;

/// <summary>
/// Classe de programa padr�o para cria��o da aplica��o.
/// As configura��es do 'builder' e 'app' est�o no appsettings.json, que
/// � incorporado no execut�vel da aplica��o.
/// </summary>
public class Program : HotAPIServer {
    /// <summary>
    /// M�todo 'main' padr�o da HotAPI
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args) {
        MainDefault<Program>();
    }
}