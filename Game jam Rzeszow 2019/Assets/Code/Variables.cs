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
            peopleImg.fillAmount = people / 100;
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
            natureImg.fillAmount = people / 100;
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
            industryImg.fillAmount = people / 100;
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
            scienceImg.fillAmount = people / 100;
        }
    }

    private void Start()
    {
        People = 100;
        Nature = 100;
        Industry = 100;
        Science = 100;
    }
}
