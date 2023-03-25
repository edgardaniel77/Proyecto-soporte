using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TicketsDB
    {
        
            string cadena = "server=localhost; user=root; database=evaluacion; password=1234;";

            public TicketsDB()
            {
            }

            public TicketsDB(Login login)

            {
                Tickets user = null;
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT * FROM  WHERE usuarios WHERE CodigoUsuario = @CodigoUsuario AND Contrasena = @Contrasena;");

                    using (MySqlConnection _conexion = new MySqlConnection(cadena))
                    {
                        _conexion.Open();
                        using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                        {
                            comando.CommandType = CommandType.Text;
                            comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                            comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 50).Value = login.Contraseña;

                            MySqlDataReader dr = comando.ExecuteReader();
                            if (dr.Read())
                            {
                                user = new Login();
                                user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                                user.Contraseña = dr["Contraseña"].ToString();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {

                }
            }
        }

    }