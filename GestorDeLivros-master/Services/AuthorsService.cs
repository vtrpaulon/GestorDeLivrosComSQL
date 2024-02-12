using System.Data.SqlClient;
using GestaoLivros.Database;

namespace GestaoLivros.Services;

public class AuthorsService
{
    private static readonly string DbConnection = ConnectionString.DbConnection;

    public static void GetAuthors()
    {
        using (SqlConnection connection = new SqlConnection(DbConnection))
        {
            connection.Open();
            string query = "select * from Autor";
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {                    
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["nome"]}");
                    }    
                }
            }
        } 
    }
    
    public static void GetAuthorById(int id)
    {
        using (SqlConnection connection = new SqlConnection(DbConnection))
        {
            connection.Open();
            string query = $"select Nome from Autor where Id = {id}";
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["nome"]}");
                    }    
                }
            }
        } 
    }

    //adiconar autor
    public static void AddAuthor(string nome)
    {
        using (SqlConnection connection = new SqlConnection(DbConnection))
        {
            connection.Open();
            string query = $"insert into Autor (Nome) values ('{nome}')";
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                sqlCommand.ExecuteNonQuery();
            }
        }
    }

    //deletar
    public static void DeleteAuthor()
    {
        using (SqlConnection connection = new SqlConnection())
        {
            connection.open();
            string query = $"delete from Autor where Id = '{id}'";

            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                sqlCommand.ExecuteNonQuery();
            }
        }
    }

}