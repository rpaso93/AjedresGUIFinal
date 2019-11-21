using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace ajedrezForm
{
    class DBconnect
    {
        //private static SQLiteConnection con = new SQLiteConnection(@"Data Source=DB/DBAjedrez.db3;Version=3;");
        //private static SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\Patricio\Desktop\GUI ajedrez\AjedrezGUI-master\ajedrezForm\DB\DBAjedrez.db3;Version=3");

        private static SQLiteConnection con;

        public static void iniciarConexion()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            //AppDomain.CurrentDomain.SetData("DataDirectory", path);

            String ConnectionString = "Data Source=";
            ConnectionString += path.Substring(0, path.Length-10);
            ConnectionString += "\\DB\\DBAjedrez.db3;Version=3";
            Console.WriteLine(ConnectionString);

            con = new SQLiteConnection(ConnectionString);
            
        }


        public static DataTable obtenerJugadas(int id)
        {



            DataTable dtJugadas = new DataTable();
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT nro_movimiento AS Nro_Movimiento, Movimiento FROM Jugadas WHERE nro_partida ="+id+"";

            SQLiteDataReader reader = cmd.ExecuteReader();

            dtJugadas.Load(reader);
            return dtJugadas;
        }

        public static int obtenerNumeroDePartida()
        {
            
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT MAX(nro_partida) AS NRO FROM Jugadas";
            
            SQLiteDataReader reader = cmd.ExecuteReader();
            int n=0;

            

            while (reader.Read() )
            {

                //if (reader.IsDBNull(0)) return 1;

                n = Convert.ToInt32(reader["NRO"]) + 1;


            }
           

            return n;
        }

        public static void agregarJugada(int p, int id_m, String s)
        {
            
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO Jugadas(nro_partida, nro_movimiento, Movimiento) VALUES (" +p+","+ id_m + ", '" + s +"')";
            cmd.ExecuteNonQuery();

        }

        public static void cerrarConexion()
        {
            con.Close();
        }
    }
}
