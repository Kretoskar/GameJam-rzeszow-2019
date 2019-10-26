using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    private Fader fader;

    private int people;
    public int People {
        get
        {
            return people;
        }
        set
        {
            people = value;
            if (people >= 100)
                GameOver();
            if (people <= 0)
                GameOver();
            if(peopleImg != null)
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
            if (nature >= 100)
                GameOver();
            if (nature <= 0)
                GameOver();
            if(natureImg != null)
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
            if (industry >= 100)
                GameOver();
            if (industry <= 0)
                GameOver();
            if(industryImg != null)
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
            if (science >= 100)
                GameOver();
            if (science <= 0)
                GameOver();
            if(scienceImg != null)
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

    private bool isDead = false;
    public bool IsDead { get => isDead; set => isDead = value; }


    private void Awake()
    {
        People = PlayerPrefs.GetInt("People", 50);
        Nature = PlayerPrefs.GetInt("Nature", 50);
        Industry = PlayerPrefs.GetInt("Industry", 50);
        Science = PlayerPrefs.GetInt("Science", 50);
        DaysSurvived = PlayerPrefs.GetInt("DaysSurvived", 0);
    }

    private void Start()
    {
        fader = FindObjectOfType<Fader>();
    }

    private void GameOver()
    {
        PlayerPrefs.SetInt("People", 50);
        PlayerPrefs.SetInt("Nature", 50);
        PlayerPrefs.SetInt("Industry", 50);
        PlayerPrefs.SetInt("Science", 50);
        PlayerPrefs.SetInt("DaysSurvived", 0);
        StartCoroutine("GOCoroutine");
    }

    private IEnumerator GOCoroutine()
    {
        isDead = true;
        yield return new WaitForSeconds(2);
        fader.LoadScene(3);
    }
}
