using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace Agenda
{
    internal class Repository
    {
        private readonly SqlConnection connection;
        private const string NombreBD = "Agenda";

        #region Repository
        public Repository()
        {
            connection = ContextDB.CreateConnection(NombreBD);
        }
        #endregion

        #region GetAllContacts
        public List<Contacto> GetAllContacts()
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction("ObtenerContactos");

            SqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.Transaction = transaction;
            List<Contacto> lista = new List<Contacto>();

            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "GetContacts";
                if (connection != null)
                {
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        lista.Add(new Contacto(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetString(3),
                            reader.GetString(4)
                            ));
                    }
                    reader.Close();
                }
                
                transaction.Commit();
            }catch (Exception ex)
            {
                
                transaction.Rollback();
                Console.WriteLine(ex.ToString());
            }finally
            {
                connection.Close();
            }

            return lista;
        }
        #endregion

        #region AddContacts
        public void AniadirContacto(int id, string nombre, string FechaNacimiento, string telefono, string? Observacion)
        {
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction("AniadirContacto");

            SqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.Transaction = transaction;

            try
            {
                command.CommandText = $"INSERT INTO Contactos VALUES ('{nombre}','{FechaNacimiento}','{telefono}','{Observacion}')";
                if (connection != null)
                {
           
                    command.ExecuteNonQuery();
                    MessageBox.Show("\nDatos insertados con éxito");
                }

                transaction.Commit();

            }catch (Exception ex)
            {
                transaction.Rollback();
                Debug.WriteLine(ex.ToString());
            }finally
            {
                connection.Close();
            }
        }
        #endregion

        #region GetContactById
        public Contacto GetContactById(int id)
        {
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction("ObtenerContactoPorId");

            SqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.Transaction = transaction;
       
            Contacto contacto = null;

            try
            {
                command.CommandText = $"SELECT * FROM Contactos WHERE ID = {id}";
                if (connection != null)
                {          
                    SqlDataReader reader = command.ExecuteReader();


                    reader.Read();
                    contacto = new Contacto(
                                            reader.GetInt32(0),
                                            reader.GetString(1),
                                            reader.GetDateTime(2),
                                            reader.GetString(3),
                                            reader.GetString(4),
                                            reader.GetString(5));
                            
                    reader.Close();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return contacto;
        }
        #endregion

        #region ErraseContactById
        public void ErraseContactById(int id)
        {
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction("EliminarContactoPorId");

            SqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.Transaction = transaction;

            try
            {
                command.CommandText = $"DELETE FROM Contactos WHERE Id = {id}";
                if (connection != null)
                {
                   
                    command.ExecuteNonQuery();

                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region AlterContactById
        public void AlterContactById(int id, string nombre, DateTime FechaNacimiento, string telefono, string? Observacion)
        {
            connection.Open();

            string query = $"UPDATE Contactos SET Nombre = '{nombre}', FechaNacimiento = '{FechaNacimiento.Year}-{FechaNacimiento.Month}-{FechaNacimiento.Day}', Telefono = '{telefono}',Observaciones = '{Observacion}' WHERE Id = {id}";

            try
            {
                if (connection != null)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
    }
}
