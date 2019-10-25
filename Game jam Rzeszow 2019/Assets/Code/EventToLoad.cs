using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventToLoad : MonoBehaviour
{
    [SerializeField]
    private EventToLoadSO eventToLoadSO;

    public EventToLoadSO EventToLoadSO { get => eventToLoadSO; set => eventToLoadSO = value; }

    public void SetEventToLoad(EventType eventToload)
    {
        EventToLoadSO.EventToLoad = eventToload;
    }
}
