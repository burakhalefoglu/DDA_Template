using System.Collections;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using UnityEngine;


public class DataAccess : MonoBehaviour
{
    GettingDatabaseParameters gettingDatabaseParameters;
    SqlConnection baglan;
    void Awake()
    {
        gettingDatabaseParameters = GetComponent<GettingDatabaseParameters>();
        baglan = new SqlConnection("Data Source=20.71.17.141; Initial Catalog=appneuron; User Id=Emre; password=123456;");
       
    }
   
      public void verileriekle()
        {
           // try
           // {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                string kayit = "insert into users(devideid,remaininghealth,attackspeed,hitrate,isdead,finishingtime,currentdifficulty,currentlevel) values (@devideid,@remaininghealth,@attackspeed,@hitrate,@isdead,@finishingtime,@currentdifficulty,@currentlevel)";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@devideid", 123456789/*PlayerPrefs.GetInt("DevideId")*/);
                komut.Parameters.AddWithValue("@remaininghealth", gettingDatabaseParameters.RemainingHealth());
                komut.Parameters.AddWithValue("@attackspeed", gettingDatabaseParameters.AttackSpeed());
                komut.Parameters.AddWithValue("@hitrate", gettingDatabaseParameters.HitRate());
                komut.Parameters.AddWithValue("@isdead", gettingDatabaseParameters.IsDead());
                komut.Parameters.AddWithValue("@finishingtime", gettingDatabaseParameters.FinishingTime());
                komut.Parameters.AddWithValue("@currentdifficulty", PlayerPrefs.GetFloat("DifficultyLevel"));
                komut.Parameters.AddWithValue("@currentlevel", PlayerPrefs.GetFloat("CurrentLevel"));
                komut.ExecuteNonQuery();
                baglan.Close();
                
           // }
      }

}
