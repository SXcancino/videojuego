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


    public void guardarSesion(string niño, string tipo_partida, int exitosos, int fallidos, int intentos, int segundos, int dificultad){
        using (var db = new SqliteConnection(this.dbName)){
            db.Open();

            using (var query = db.CreateCommand())
            {
                query.CommandText = "insert into sesiones" +
                "(id_niño, tipo_partida, intentos_exitosos, intentos_fallidos, intentos, tiempo_jugado,dificultad)" +
                "values (@id,@tipo,@exitosos,@fallidos,@intentos,@segundos,@dificultad)";

                IDbDataParameter paramId = query.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = niño;
                query.Parameters.Add(paramId);

                IDbDataParameter paramTipo = query.CreateParameter();
                paramTipo.ParameterName = "@tipo";
                paramTipo.Value = tipo_partida;
                query.Parameters.Add(paramTipo);

                IDbDataParameter paramExitoso = query.CreateParameter();
                paramExitoso.ParameterName = "@exitosos";
                paramExitoso.Value = exitosos;
                query.Parameters.Add(paramExitoso);
                
                IDbDataParameter paramFallido = query.CreateParameter();
                paramFallido.ParameterName = "@fallidos";
                paramFallido.Value = fallidos;
                query.Parameters.Add(paramFallido);

                IDbDataParameter paramIntentos = query.CreateParameter();
                paramIntentos.ParameterName = "@intentos";
                paramIntentos.Value = intentos;
                query.Parameters.Add(paramIntentos);

                IDbDataParameter paramTiempo = query.CreateParameter();
                paramTiempo.ParameterName = "@segundos";
                paramTiempo.Value = segundos;
                query.Parameters.Add(paramTiempo);

                IDbDataParameter paramDif = query.CreateParameter();
                paramDif.ParameterName = "@dificultad";
                paramDif.Value = dificultad;
                query.Parameters.Add(paramDif);

                query.ExecuteNonQuery();
            }
            db.Close();
        }
    }

    public void getSesiones(string n){

    }
}
