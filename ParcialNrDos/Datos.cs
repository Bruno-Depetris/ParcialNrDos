using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace ParcialNrDos {
    public class Datos {

        //Me falta probar la conexion pq en el trabajo no tengo y tube q usar SQLITE jaja viva peron
        private string cadenaConexion = "" +
            "";

        public Hashtable ObtenerBarrios() {
            Hashtable barrios = new Hashtable();

            string consulta = "SELECT Id, Nombre FROM Barrios";

            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            conexion.Open();

            while (lector.Read()) {
                int id = Convert.ToInt32(lector["Id"]);
                string nombre = lector["Nombre"].ToString();
                barrios.Add(id, nombre);
            }
            lector.Close();

            conexion.Close();

            return barrios;
        }

        public bool GuardarPropiedad(Propiedad propiedad) {


            string consulta = "INSERT INTO Propiedades (Nombre, Direccion, Precio, IdBarrio) VALUES ('" + propiedad.Nombre + "', '" + propiedad.Direccion + "', " + propiedad.Precio + ", " + propiedad.IdBarrio + ")";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();

            int rowsAfect = comando.ExecuteNonQuery();
            conexion.Close();
            if (rowsAfect > 0) {
                return true;
            }

            return false;


        }

        public ArrayList ObtenerPropiedades() {
            ArrayList datosObtenidos = new ArrayList();

            //SENTENCIA BASICA SQL hay mil formas de no hacer el inner join si quieren pueden hacer el plan B que te dejo abajo
            string consulta = " SELECT " +
                "Prop.Id, " +
                "Prop.Nombre, " +
                "Prop.Direccion, " +
                "Prop.Precio, " +
                "Bar.Nombre AS Barrio "
                + "FROM Propiedades Prop " +
                "INNER JOIN Barrios Bar ON Prop.IdBarrio = Bar.Id ";

            
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlDataReader lector = comando.ExecuteReader();

            conexion.Open();

            while (lector.Read()) {
                PropiedadBarrio prop = new PropiedadBarrio();
                prop.Id = Convert.ToInt32(lector["Id"]);
                prop.Nombre = lector["Nombre"].ToString();
                prop.Direccion = lector["Direccion"].ToString();
                prop.Precio = Convert.ToDecimal(lector["Precio"]);
                prop.Barrio = lector["Barrio"].ToString();

                datosObtenidos.Add(prop);
            }

            conexion.Close();

            return datosObtenidos;
        }

        #region opcion dos
        //dale no pueden quejarse hay mil formas de que resuelvan
        public string ObtenerNombreBarrio(int id) {
            string consulta = "SELECT Nombre FROM Barrios WHERE IdBarrio = " + );
            string nombre = "";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            conexion.Open();

            while (lector.Read()) {
                nombre = lector["Nombre"].ToString();
            }
            lector.Close();

            conexion.Close();

            return nombre;
        }
        public ArrayList ObtenerPropiedadesOP2() {
            ArrayList datosObtenidos = new ArrayList();

            foreach(Propiedad prop in ObtenerPropiedades()) {
                PropiedadBarrio propBar = new PropiedadBarrio();
                propBar.Id = prop.Id;
                propBar.Nombre = prop.Nombre;
                propBar.Precio = prop.Precio;
                propBar.Barrio = ObtenerNombreBarrio(prop.Id);
                datosObtenidos.Add(propBar);
            }

            return datosObtenidos;
        }

        #endregion

        public bool EliminarPropiedad(int idPropiedad) {
            string consulta = "DELETE FROM Propiedades WHERE Id = " + idPropiedad;

            int rowsAfect = 0;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            rowsAfect = comando.ExecuteNonQuery();

            conexion.Close();


            if (rowsAfect > 0) {
                return true;
            }
            return false;
        }
    }
}
