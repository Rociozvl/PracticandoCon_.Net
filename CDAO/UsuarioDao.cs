using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Org.BouncyCastle.Asn1;
using System.Reflection.Metadata.Ecma335;
using CDAO.Modelo;
using System.Data;
using System.Data.Common;

namespace CDAO
{
    public class UsuarioDao
    {
        private readonly string _conex;


        public UsuarioDao(string _conex)

        {
            this._conex = _conex;

        }
        public IEnumerable<Modelo.Usuario> ObtenerTodos()
        {

            using (var connection = new MySqlConnection(_conex))
            {

                connection.Open();
                return connection.Query<Modelo.Usuario>("SELECT * FROM Usuarios");


            }

        }
        public void Insertar(Usuario usuario)
        {
            string sqlCustomerInsert = "INSERT INTO usuarios (nombre , edad ) Values (@nombre , @edad);";
            try
            {
                using (var connection = new MySqlConnection(_conex))
                {

                    connection.Open();

                    var affectedRows = connection.Execute(sqlCustomerInsert, new { nombre= "pepe" , edad=18 });
                    Console.WriteLine(affectedRows);
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
           }
        public void Actualizar(Usuario usuario)
        {
            string sqlCustomerUpdate= "UPDATE usuarios SET nombre = @nombre, edad = @edad WHERE id = @id";
            using (var connection = new MySqlConnection(_conex))
            {

                connection.Open();
               
                var affectedRows = connection.Execute(sqlCustomerUpdate, new { nombre = "pepe", edad = 18 , id=2 });
                Console.WriteLine(affectedRows);


            }

        }
        public void Eliminar(Usuario usuario)
        {
            string sqlCustomerDelete = "UPDATE usuarios SET Estado = 'inactivo' WHERE id = @id ";
            using (var connection = new MySqlConnection(_conex))
            {

                connection.Open();

                var affectedRows = connection.Execute(sqlCustomerDelete, new { id = 4 });
                Console.WriteLine(affectedRows);


            }

        }



    }
}
    

