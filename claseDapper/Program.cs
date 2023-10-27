using MySql.Data.MySqlClient;
using Dapper;

string sqlSelect = "SELECT * FROM usuarios;";

string Stringconnection = "Server = localhost; Port=3306;Database=prueba;User=root;Password=usuario73;
using (var connection = new MySqlConnection(connectionString))
{
    connection.Open();

    string query = "SELECT * FROM Customers WHERE Country = @Country";

    var result = connection.Query(query, new { Country = "USA" });

    foreach (var row in result)
    {
        // Access the data using row.ColumnName
    }
}
