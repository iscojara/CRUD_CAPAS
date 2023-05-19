using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Data Source = VIVOBOOK_2021\\SQLEXPRESS; Initial Catalog = Practica; Integrated Security = true");
        //Data Source = VIVOBOOK_2021\\SQLEXPRESS; Initial Catalog = Practica; Integrated Security = true
        public SqlConnection AbrirConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Closed)
                    Conexion.Open();
                return Conexion;
            }
            catch(Exception ex)
            {
                return null;
                //MessageBox.Show("seleccione una fila por favor");
            }
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
