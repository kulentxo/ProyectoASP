using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PruebaProyecto1
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["DAM_Compartido_DEVConnectionString"].ToString();
            using (SqlConnection sqlConn = new SqlConnection(strConnectionString))
            {
                SqlCommand comando = new SqlCommand("Minecraft.Registrar_Insertar", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;
                if (txtPass.Text == txtPass2.Text)
                {
                    comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@pass", txtPass.Text);
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    comando.Parameters.AddWithValue("@fecha", txtFec.Text);
                    sqlConn.Open();
                    comando.ExecuteNonQuery();
                    sqlConn.Close();
                }
                else
                    Response.Write("Tienes que introducir la misma contraseña dos veces");
               
            }
        }
        protected void btnIniciar_Click(object sender, EventArgs e)
        {

            int resul;
            string strConnectionString = ConfigurationManager.ConnectionStrings["DAM_Compartido_DEVConnectionString"].ToString();
            using (SqlConnection sqlConn = new SqlConnection(strConnectionString))
            {
                SqlCommand comando = new SqlCommand("Minecraft.IniciarSesion", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@usuario", (TextBox1.Text).ToString());
                comando.Parameters.AddWithValue("@pass", (TextBox2.Text).ToString());
                comando.Parameters.Add("@resultado", SqlDbType.TinyInt).Direction = ParameterDirection.Output;
                sqlConn.Open();
                comando.ExecuteNonQuery();
                resul = Int32.Parse(comando.Parameters["@resultado"].Value.ToString());
                sqlConn.Close();
            }
            if(resul == 1)
            {
                Session["Usuario"] = TextBox1.Text.ToString();
                Response.Redirect("WebForm1.aspx");
            }
        }
    }
}