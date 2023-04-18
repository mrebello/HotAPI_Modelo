namespace HotAPI_Modelo;

/// <summary>
/// Classe de programa padrão para criação da aplicação.
/// As configurações do 'builder' e 'app' estão no appsettings.json, que
/// é incorporado no executável da aplicação. Configurações padrão estão
/// incluídas nas DLLs das bibliotecas (Hot.DLL e HotAPI.DLL)
/// </summary>
public class Program : HotAPIServer {
    /// <summary>
    /// Método 'main' padrão da HotAPI
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args) {
        MainDefault<Program>();
    }
}