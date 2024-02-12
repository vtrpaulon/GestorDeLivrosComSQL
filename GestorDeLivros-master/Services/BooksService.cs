using System.Data.SqlClient;
using GestaoLivros.Database;

namespace GestaoLivros.Services
{
    internal static class BooksService
    {
        private static readonly string DbConnection = ConnectionString.DbConnection;
        
        public static void GetBooks()
        {
            using (SqlConnection connection = new SqlConnection(DbConnection))
            {
                connection.Open();
                string query = "select * from Livro";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    string query = "select * from Livro";
                    sqlCommand.ExecuteNonQuery();
                    
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var titulo = reader['titulo'];
                            var autor = reader['Autor'];
                            var anoPublicacao = reader['AnoPublicacao'];
                            var autorId = reader['AutorId'];

                            Console.WriteLine($"Titulo: {titulo}\n Autor: {autor}\n Ano de Publicacao: {anoPublicacao}");
                        }    
                    }
                }
            }                
        }
    }
}