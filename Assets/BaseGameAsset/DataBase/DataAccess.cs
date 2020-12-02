using System.Collections;
using System.Collections.Generic;
using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using UnityEngine;

public class DataAccess : MonoBehaviour
{
    GettingDatabaseParameters gettingDatabaseParameters;
    MySqlConnection conn;

    void Start()
    {
        gettingDatabaseParameters = GetComponent<GettingDatabaseParameters>();

        string server = "35.240.51.25";
        string database = "appneuron";
        string uid = "root";
        string password = "Developer123";
        string connectionString;

        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        conn = new MySqlConnection(connectionString);



    }
    public void verileriekle()
    {
		conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;

        cmd.CommandText = "INSERT INTO users (devideid,remaininghealth,attackspeed,hitrate,isdead,finishingtime,currentdifficulty,currentlevel)" +
                          " VALUES (@devideid,@remaininghealth,@attackspeed,@hitrate,@isdead,@finishingtime,@currentdifficulty,@currentlevel)";

        cmd.Parameters.AddWithValue("@devideid", PlayerPrefs.GetInt("DevideId"));
        cmd.Parameters.AddWithValue("@remaininghealth", gettingDatabaseParameters.RemainingHealth());
        cmd.Parameters.AddWithValue("@attackspeed", gettingDatabaseParameters.AttackSpeed());
        cmd.Parameters.AddWithValue("@hitrate", gettingDatabaseParameters.HitRate());
        cmd.Parameters.AddWithValue("@isdead", gettingDatabaseParameters.IsDead());
        cmd.Parameters.AddWithValue("@finishingtime", gettingDatabaseParameters.FinishingTime());
        cmd.Parameters.AddWithValue("@currentdifficulty", PlayerPrefs.GetInt("DifficultyLevel"));
        cmd.Parameters.AddWithValue("@currentlevel", PlayerPrefs.GetFloat("CurrentLevel"));
        cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        Debug.Log("Done.");
    }


}


