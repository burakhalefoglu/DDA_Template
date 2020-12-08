using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class anket : MonoBehaviour
{


    GettingDatabaseParameters gettingDatabaseParameters;

    GameObject GameUI;
    GameObject MobileInput;
    GameObject ResumePause;


    void Start()
    {
        MobileInput = GameObject.FindGameObjectWithTag("MobileInput");
        GameUI = GameObject.FindGameObjectWithTag("GameUI");
        ResumePause = GameObject.FindGameObjectWithTag("ResumePause");

        gettingDatabaseParameters = GetComponent<GettingDatabaseParameters>();



        if (PlayerPrefs.HasKey("IsSurveySend"))
        {
            if (PlayerPrefs.GetFloat("IsSurveySend") == 1)
            {
                this.gameObject.SetActive(false);
            }
        }
        else
        {
            StartCoroutine(LateStart(0.1f));
        }


    }

    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Time.timeScale = 0;
        GameUI.SetActive(false);
        MobileInput.SetActive(false);
        ResumePause.SetActive(false);

    }


    public void verilerigonder(int deger)
    {
        StartCoroutine(ConnectServer(deger));
    }



    IEnumerator ConnectServer(int result)
    {
        WWWForm DataForm = new WWWForm();
        DataForm.AddField("devideid", PlayerPrefs.GetInt("DevideId"));
        DataForm.AddField("result", result.ToString());

        using (UnityWebRequest www = UnityWebRequest.Post("https://mydataacess.000webhostapp.com/anket.php", DataForm))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
                PlayerPrefs.SetFloat("IsSurveySend", 1);
            }

            this.gameObject.SetActive(false);
            GameUI.SetActive(true);
            MobileInput.SetActive(true);
            ResumePause.SetActive(true);
            Time.timeScale = 1;

        }


    }
}
