using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event", menuName = "ScriptableObjects/Events")]
public class EventSO : ScriptableObject
{
    [SerializeField]
    private string eventText;
    [SerializeField]
    private string answerAText;
    [SerializeField]
    private string answerBText;
    [SerializeField]
    private string answerCText;
    [SerializeField]
    private Sprite backgroundSprite;
    [SerializeField]
    private EventType eventType;

    [Header("A")]
    [SerializeField]
    private int AToPeople;
    [SerializeField]
    private int AToNature;
    [SerializeField]
    private int AToIndustry;
    [SerializeField]
    private int AToScience;

    [Header("B")]
    [SerializeField]
    private int BToPeople;
    [SerializeField]
    private int BToNature;
    [SerializeField]
    private int BToIndustry;
    [SerializeField]
    private int BToScience;

    [Header("C")]
    [SerializeField]
    private int CToPeople;
    [SerializeField]
    private int CToNature;
    [SerializeField]
    private int CToIndustry;
    [SerializeField]
    private int CToScience;

    public string EventText { get => eventText; set => eventText = value; }
    public string AnswerAText { get => answerAText; set => answerAText = value; }
    public string AnswerBText { get => answerBText; set => answerBText = value; }
    public string AnswerCText { get => answerCText; set => answerCText = value; }
    public Sprite BackgroundSprite { get => backgroundSprite; set => backgroundSprite = value; }
    public int AToPeople1 { get => AToPeople; set => AToPeople = value; }
    public int AToNature1 { get => AToNature; set => AToNature = value; }
    public int AToIndustry1 { get => AToIndustry; set => AToIndustry = value; }
    public int AToScience1 { get => AToScience; set => AToScience = value; }
    public int BToPeople1 { get => BToPeople; set => BToPeople = value; }
    public int BToNature1 { get => BToNature; set => BToNature = value; }
    public int BToIndustry1 { get => BToIndustry; set => BToIndustry = value; }
    public int BToScience1 { get => BToScience; set => BToScience = value; }
    public int CToPeople1 { get => CToPeople; set => CToPeople = value; }
    public int CToNature1 { get => CToNature; set => CToNature = value; }
    public int CToIndustry1 { get => CToIndustry; set => CToIndustry = value; }
    public int CToScience1 { get => CToScience; set => CToScience = value; }
}

public enum EventType
{
    City,
    Forest,
    Factories,
    Reaserch
}
