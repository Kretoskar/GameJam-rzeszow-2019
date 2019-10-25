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
            peopleImg.fillAmount = (float)people / 100;
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
            natureImg.fillAmount = (float)people / 100;
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
            industryImg.fillAmount = (float)people / 100;
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
            scienceImg.fillAmount = (float)people / 100;
        }
    }

    private void Start()
    {
        People = 50;
        Nature = 50;
        Industry = 50;
        Science = 50;
    }
}
