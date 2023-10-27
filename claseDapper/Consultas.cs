using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace claseDapper
{
    internal class Consultas
    {
        string sqlSelect= "SELECT * FROM usuarios;";
       
        readonly string connection = "Server = localhost; Port=3306;Database=prueba;User=root;Password=usuario73;";
using  (var connection = new MySqlConnection(FiddleHelper.GetConnectionStringSqlServerW3Schools()));
{
    var usuarios = connection.Query<Usuario>(sqlSelect).ToList();
   

    Console.WriteLine(usuarios.Count);
    Console.WriteLine(affectedRows);

    FiddleHelper.WriteTable(usuarios);
    FiddleHelper.WriteTable(new List<usuarios>() { usuarios});
}
    
}
