using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadFromSO : MonoBehaviour
{
    [SerializeField]
    private EventSO eventSo;
    [SerializeField]
    private Text eventText;
    [SerializeField]
    private Text answerAText;
    [SerializeField]
    private Text answerBText;
    [SerializeField]
    private Text answerCText;

    public void Load(EventSO eventSo)
    {
        eventText.text = eventSo.EventText;
        answerAText.text = eventSo.AnswerAText;
        answerBText.text = eventSo.AnswerBText;
        answerCText.text = eventSo.AnswerCText;
    }
}
