using System.Collections;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using UnityEngine;


public class DataAccess : MonoBehaviour
{
    GettingDatabaseParameters gettingDatabaseParameters;
    SqlConnection conn;
    void Awake()
    {
        gettingDatabaseParameters = GetComponent<GettingDatabaseParameters>();
        conn = new SqlConnection("Server=tcp:appneurondb.database.windows.net,1433;Initial Catalog=appneuron;Persist Security Info=False;User ID=burak;Password=Developer123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            /* ("Data Source=20.73.17.141; Initial Catalog=appneuron; User Id=Emre; password=123456;");*/

    }

    public void verileriekle()
    {



        using (var cmd = conn.CreateCommand())
        {
            cmd.CommandText = @"INSERT INTO users (devideid,remaininghealth,attackspeed,hitrate,isdead,finishingtime,currentdifficulty,currentlevel)
                                VALUES (@devideid,@remaininghealth,@attackspeed,@hitrate,@isdead,@finishingtime,@currentdifficulty,@currentlevel)";

            cmd.Parameters.AddWithValue("@devideid", 123456789/*PlayerPrefs.GetInt("DevideId")*/);
            cmd.Parameters.AddWithValue("@remaininghealth", gettingDatabaseParameters.RemainingHealth());
            cmd.Parameters.AddWithValue("@attackspeed", gettingDatabaseParameters.AttackSpeed());
            cmd.Parameters.AddWithValue("@hitrate", gettingDatabaseParameters.HitRate());
            cmd.Parameters.AddWithValue("@isdead", gettingDatabaseParameters.IsDead());
            cmd.Parameters.AddWithValue("@finishingtime", gettingDatabaseParameters.FinishingTime());
            cmd.Parameters.AddWithValue("@currentdifficulty", PlayerPrefs.GetFloat("DifficultyLevel"));
            cmd.Parameters.AddWithValue("@currentlevel", PlayerPrefs.GetFloat("CurrentLevel"));

            conn.Open();
            cmd.ExecuteNonQuery();

        }


    }



}


