using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataToScreen : MonoBehaviour
{

    [SerializeField]
    Text DifficultyLevel;
    [SerializeField]
    Text CharLevel;
    [SerializeField]
    Text Player_Flow;
    [SerializeField]
    Text Player_Health;
    [SerializeField]
    Text CuteBacterium_Density;
    [SerializeField]
    Text CuteMushy_Density;
    [SerializeField]
    Text BloodCell_Density;

    private void Start()
    {
        DifficultyLevel.text = "DifficultyLevel:  " + 1;/* PlayerPrefs.GetFloat("DifficultyLevel").ToString();
*/        CharLevel.text = "CharLevel:  " + PlayerPrefs.GetFloat("CharLevel").ToString();
        Player_Flow.text = "Player_Flow:  " + PlayerPrefs.GetFloat("Player_Flow").ToString();
        Player_Health.text = "Player_Health:  " + PlayerPrefs.GetFloat("Player_Health").ToString();
        CuteBacterium_Density.text = "CuteBacterium_Density:  " + PlayerPrefs.GetFloat("CuteBacterium_Density").ToString();
        CuteMushy_Density.text = "CuteMushy_Density:  " + PlayerPrefs.GetFloat("CuteMushy_Density").ToString();
        BloodCell_Density.text = "BloodCell_Density:  " + PlayerPrefs.GetFloat("BloodCell_Density").ToString();
    }





}
