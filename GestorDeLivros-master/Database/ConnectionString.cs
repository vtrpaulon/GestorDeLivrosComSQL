using System.Data.SqlClient;

namespace GestaoLivros.Database;

public static class ConnectionString
{
    public static readonly string DbConnection = new SqlConnectionStringBuilder()
    {
        DataSource = "DESKTOP-336N0H9",        
        InitialCatalog = "GerenciadorDeLivros",
        UserID = "DESKTOP-336N0H9\\Vitor",
        Password = "",
        IntegratedSecurity = true
    }.ConnectionString;
}