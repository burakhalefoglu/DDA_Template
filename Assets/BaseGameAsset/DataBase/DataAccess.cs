using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class DataAccess : MonoBehaviour
{
    GettingDatabaseParameters gettingDatabaseParameters;

    void Start()
    {
        gettingDatabaseParameters = GetComponent<GettingDatabaseParameters>();
    }


    public void verileriekle()
    {
        StartCoroutine(ConnectServer());

    }


    IEnumerator ConnectServer()
    {
        WWWForm DataForm = new WWWForm();
        DataForm.AddField("devideid", PlayerPrefs.GetInt("DevideId"));
        DataForm.AddField("remaininghealth", gettingDatabaseParameters.RemainingHealth().ToString());
        DataForm.AddField("attackspeed", gettingDatabaseParameters.AttackSpeed().ToString());
        DataForm.AddField("hitrate", gettingDatabaseParameters.HitRate().ToString());
        DataForm.AddField("isdead", gettingDatabaseParameters.IsDead().ToString());
        DataForm.AddField("finishingtime", gettingDatabaseParameters.FinishingTime().ToString());
        DataForm.AddField("currentdifficulty", PlayerPrefs.GetInt("DifficultyLevel").ToString());
        DataForm.AddField("currentlevel", PlayerPrefs.GetFloat("CurrentLevel").ToString());

        using (UnityWebRequest www = UnityWebRequest.Post("https://mydataacess.000webhostapp.com/davranisdata.php", DataForm))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
            }



        }
    }



}


