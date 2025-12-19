using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace libreriaIII2025
{
    public class Utilidades
    {
        //Conexión
        //Escribir la cadena de conexión a la base de datos "CAMBIARA EN CADA UNO SEGUN LA BASE DE DATOS QUE SE USE";Trust Server Certificate=True

        public static DataSet ejecutar(string comando)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-U1S88HRT\CURSOSQL2022;Initial Catalog=BD_USADOSCR;Integrated Security=True");
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando, conn);
            adaptador.Fill(ds);
            conn.Close();
            return ds;
        }
        
        public static string codificar(string contrasena)
        {
            byte[] datos = Encoding.UTF8.GetBytes(contrasena);
            return System.Convert.ToBase64String(datos);


        }
        public static string decodificar(string contrasena)
        {
            byte[] datos = Convert.FromBase64String(contrasena);
            return Encoding.UTF8.GetString(datos, 0, datos.Length);

        }
    }
}
