using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_2
{
    class Program
    {
        static void Main(string[] args)
        {

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|Database.accdb");

            conexion.Open();

            Console.WriteLine("Escribe el nombre");
            String nombre = Console.ReadLine();

            Console.WriteLine("Escribe los apellidos");
            String apellidos = Console.ReadLine();

            Console.WriteLine("Escribe la edad");
            int edad = Convert.ToInt32(Console.ReadLine());

            String sql = "INSERT INTO clientes (nombre, apellidos, edad) VALUES(";
            sql += "'"+nombre+"', ";
            sql += "'" + apellidos + "', ";
            sql += edad + ");";

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conexion;
            cmd.CommandText = @sql;

            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Se ha insertado los datos correctamente");
            }
            else
            {
                Console.WriteLine("No se ha insertado los datos correctamente");
            }


            conexion.Close();

            Console.ReadLine();

        }
    }
}
