using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class eventoRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=none;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        //Ejercicio 1
        internal evento Retrieve(evento p, mercado m)
        {
            
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "INSERT INTO partido(tipo_mercado,Equipo_Local,Equipo_visitante,) values ('" + m.tipo_mercado + "','" + p.Equipo_Local + "','" + p.Equipo_visitante + "')FROM partido p INNER JOIN mercado m;";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            evento e = null;


            //Devolver objeto evento. Se devolvera un registro y lo añadira a la lista
            if (res.Read()){
                e = new evento(res.GetInt32(0), res.GetString(1), res.GetString(2));
            }

            con.Close();
            return e;
        }
        //Fin Ejercicio 1

        internal eventoDTO RetrieveDTO()
        {
            //Devuelve todos los registros
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select * from partido";

                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                eventoDTO e = null;


                //Devolver objeto evento. Se devolvera un registro
                if (res.Read())
                {
                    e = new eventoDTO(res.GetString(0), res.GetString(1));
                }

                con.Close();
                return e;


        }
    }
}