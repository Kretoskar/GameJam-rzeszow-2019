using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variables : MonoBehaviour
{
    [SerializeField]
    private Image peopleImg;
    [SerializeField]
    private Image natureImg;
    [SerializeField]
    private Image industryImg;
    [SerializeField]
    private Image scienceImg;

    private int people;
    public int People {
        get
        {
            return people;
        }
        set
        {
            people = value;
            if (people > 100)
                people = 100;
            if (people < 0)
                people = 0;
            peopleImg.fillAmount = (float)people / 100;
            PlayerPrefs.SetInt("People", people);
        }
    }
    private int nature;
    public int Nature
    {
        get
        {
            return nature;
        }
        set
        {
            nature = value;
            if (nature > 100)
                nature = 100;
            if (nature < 0)
                nature = 0;
            natureImg.fillAmount = (float)nature / 100;
            PlayerPrefs.SetInt("Nature", nature);
        }
    }
    private int industry;
    public int Industry
    {
        get
        {
            return industry;
        }
        set
        {
            industry = value;
            if (industry > 100)
                industry = 100;
            if (industry < 0)
                industry = 0;
            industryImg.fillAmount = (float)industry / 100;
            PlayerPrefs.SetInt("Industry", industry);
        }
    }
    private int science;
    public int Science
    {
        get
        {
            return science;
        }
        set
        {
            science = value;
            if (science > 100)
                science = 100;
            if (science < 0)
                science = 0;
            scienceImg.fillAmount = (float)science / 100;
            PlayerPrefs.SetInt("Science", science);
        }
    }

    private int daysSurvived;
    public int DaysSurvived {
        get
        {
            return PlayerPrefs.GetInt("DaysSurvived", 0);
        }
        set
        {
            daysSurvived = value;
            PlayerPrefs.SetInt("DaysSurvived", daysSurvived);
        }
    }

    private void Awake()
    {
        People = PlayerPrefs.GetInt("People", 50);
        Nature = PlayerPrefs.GetInt("Nature", 50);
        Industry = PlayerPrefs.GetInt("Industry", 50);
        Science = PlayerPrefs.GetInt("Science", 50);
        DaysSurvived = PlayerPrefs.GetInt("DaysSurvived", 0);
    }
}
