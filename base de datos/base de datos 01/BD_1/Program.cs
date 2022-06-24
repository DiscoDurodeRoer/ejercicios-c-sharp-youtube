using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_1
{
    class Program
    {
        static void Main(string[] args)
        {

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|Database.accdb");

            conexion.Open();

            String sql = "SELECT * FROM clientes";

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            foreach (DataRow row in d.Tables[0].Rows)
            {
                Console.WriteLine("ID: " + row["ID"]);
                Console.WriteLine("nombre: " + row["nombre"]);
                Console.WriteLine("apellidos: " + row["apellidos"]);
                Console.WriteLine("edad: " + row["edad"]);
                Console.WriteLine("");
            }


            conexion.Close();

            Console.ReadLine();

        }
    }
}
