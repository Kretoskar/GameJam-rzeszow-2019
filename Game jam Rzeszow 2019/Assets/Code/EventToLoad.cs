using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventToLoad : MonoBehaviour
{
    [SerializeField]
    private EventToLoadSO eventToLoadSO;

    public void SetEventToLoad(EventType eventToload)
    {
        eventToLoadSO.EventToLoad = eventToload;
    }
}
