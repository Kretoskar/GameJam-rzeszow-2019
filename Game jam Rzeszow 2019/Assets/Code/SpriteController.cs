using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteController : MonoBehaviour
{
    [SerializeField]
    private Sprite city;
    [SerializeField]
    private Sprite forest;
    [SerializeField]
    private Sprite industry;
    [SerializeField]
    private Sprite reaserch;
    [SerializeField]
    private Image bgImage;

    private CurrentEvent currEvent;

    private void Start()
    {
        currEvent = FindObjectOfType<CurrentEvent>();
        if(currEvent.CurrentEventSO.EventType == EventType.City)
        {
            bgImage.sprite = city;
        }
        else if (currEvent.CurrentEventSO.EventType == EventType.Forest)
        {
            bgImage.sprite = forest;
        }
        else if (currEvent.CurrentEventSO.EventType == EventType.Factories)
        {
            bgImage.sprite = industry;
        }
        else if (currEvent.CurrentEventSO.EventType == EventType.Reaserch)
        {
            bgImage.sprite = reaserch;
        }
    }
}
