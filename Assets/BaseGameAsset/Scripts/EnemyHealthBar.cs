using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    private static Image HealthBarImage;

    /// <summary>
    /// Sets the health bar value
    /// </summary>
    /// <param name="value">should be between 0 to 1</param>
    public void SetHealthBarValue(float value)
    {
        HealthBarImage.fillAmount = value;


        if (HealthBarImage.fillAmount > 0.6f)
        {
            SetHealthBarColor(new Color(0f, 1f, 0f));
        }
        else if (HealthBarImage.fillAmount > 0.4f)
        {
            SetHealthBarColor(new Color(1f, 1f, 0f));
        }
        else if (HealthBarImage.fillAmount > 0.2f)
        {
            SetHealthBarColor(new Color(1f, 0f, 0f));
        }

    }

    public static float GetHealthBarValue()
    {
        return HealthBarImage.fillAmount;
    }

    /// <summary>
    /// Sets the health bar color
    /// </summary>
    /// <param name="healthColor">Color </param>
    public static void SetHealthBarColor(Color healthColor)
    {
        HealthBarImage.color = healthColor;
    }

    /// <summary>
    /// Initialize the variable
    /// </summary>
    private void Start()
    {
        HealthBarImage = GetComponent<Image>();
        SetHealthBarValue(1);


    }


}
