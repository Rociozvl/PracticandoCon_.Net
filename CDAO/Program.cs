

using CDAO;

using System;
using System.Linq;
using Dapper;
using CDAO.Modelo;

class Program

{
    

    static void Main(String[] args)
    {
        string _conex = "StringServer;";
        UsuarioDao UserDao = new UsuarioDao(_conex);

        //   List<Usuario> usuarios = (List<Usuario>)UserDao.ObtenerTodos();
        //    foreach (var usuario in usuarios)
        //    {
        //        Console.WriteLine($"ID: {usuario.id}, Nombre: {usuario.nombre}, Edad: {usuario.edad}");
        //    }

        //Usuario user = new Usuario();
        //UserDao.Insertar(user);
        //Usuario user = new Usuario();
        //UserDao.Actualizar(user);
        Usuario user = new Usuario();
        UserDao.Eliminar(user);
    }
}
