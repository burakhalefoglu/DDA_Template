using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;
using System.Data;

public class DataAccess : MonoBehaviour
{
    GettingDatabaseParameters gettingDatabaseParameters;
    void Awake()
    {
        gettingDatabaseParameters = GetComponenet<GettingDatabaseParameters>();
        SqlConnection baglan = new SqlConnection("Data Source=192.168.1.7; Initial Catalog=Kutuphane; User Id=Emre; password=123456;");
       
    }
   
      private void verileriekle()
        {
           // try
           // {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                string kayit = "insert into kitaplar(devideid,remaininghealth,attackspeed,hitrate,apm,isdead,finishingtime,currentdifficulty,currentlevel) values (@devideid,@remaininghealth,@attackspeed,@hitrate,@apm,@isdead,@finishingtime,@currentdifficulty,@currentlevel)";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@devideid", PlayerPrefs.GetInt("DevideId"));
                komut.Parameters.AddWithValue("@remaininghealth", gettingDatabaseParameters.RemainingHealth());
                komut.Parameters.AddWithValue("@attackspeed",0 );
                komut.Parameters.AddWithValue("@hitrate", 0);
                komut.Parameters.AddWithValue("@apm", 0);
                komut.Parameters.AddWithValue("@isdead", 0);
                komut.Parameters.AddWithValue("@finishingtime", 0);
                komut.Parameters.AddWithValue("@currentdifficulty", 0);
                komut.Parameters.AddWithValue("@currentlevel", 0);
                komut.ExecuteNonQuery();
                baglan.Close();
                
           // }
      }

}
