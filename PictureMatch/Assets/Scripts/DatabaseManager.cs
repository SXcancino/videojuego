using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

public class DatabaseManager
{
    public static DatabaseManager instance;
    private string dbName = "URI=file:videojuego.db";

    private void Awake()
    {
        instance=this;
    }
    
    public void addNiño(string id, string nombre){
        using (var db = new SqliteConnection(this.dbName)){
            db.Open();

            using (var query = db.CreateCommand())
            {
                query.CommandText = "INSERT INTO niños (id,nombre) values (@id, @nombre)";

                IDbDataParameter paramNombre = query.CreateParameter();
                paramNombre.ParameterName = "@nombre";
                paramNombre.Value = nombre;
                query.Parameters.Add(paramNombre);

                IDbDataParameter paramId = query.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                query.Parameters.Add(paramId);

                query.ExecuteNonQuery();
            }
            db.Close();
        }
    }
    public void eliminarNiño(string id){
        using (var db = new SqliteConnection(this.dbName))
        {
            db.Open();
            using (var query = db.CreateCommand())
            {
                query.CommandText = "DELETE FROM niños where id=@id";

                IDbDataParameter paramNombre = query.CreateParameter();
                paramNombre.ParameterName = "@id";
                paramNombre.Value = id;
                query.Parameters.Add(paramNombre);

                query.ExecuteNonQuery();
            }
            db.Close();
        }
    }
    public List<KeyValuePair<string, string>> getNiños()
    {
       List<KeyValuePair<string, string>> res = new List<KeyValuePair<string, string>>();

        using (var db = new SqliteConnection(this.dbName))
        {
            db.Open();
            using (var query = db.CreateCommand())
            {
                query.CommandText = "SELECT * FROM niños";
                using (IDataReader reader = query.ExecuteReader())
                {
                    // Verificar si hay datos antes de intentar leer
                    
                        while (reader.Read()){
                            string id = reader.GetString(0);
                            string nombre = reader.GetString(1);
                            // Acceder a los datos del registro
                            res.Add(new KeyValuePair<string, string>(id, nombre));
                        }
                    
                }
            }
            db.Close();
        }
        return res;
    }
}
