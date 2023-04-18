namespace HotAPI_Modelo;

/// <summary>
/// Classe de programa padr�o para cria��o da aplica��o.
/// As configura��es do 'builder' e 'app' est�o no appsettings.json, que
/// � incorporado no execut�vel da aplica��o. Configura��es padr�o est�o
/// inclu�das nas DLLs das bibliotecas (Hot.DLL e HotAPI.DLL)
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