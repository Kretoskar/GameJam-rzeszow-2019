using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLoader : MonoBehaviour
{
    [SerializeField]
    private List<EventSO> events = new List<EventSO>();

    private LoadFromSO loadFromSo;
    private CurrentEvent currentEvent;
    private EventToLoad eventToLoad;

    private void Start()
    {
        currentEvent = FindObjectOfType<CurrentEvent>();
        loadFromSo = FindObjectOfType<LoadFromSO>();
        eventToLoad = FindObjectOfType<EventToLoad>();
        LoadRandom();
    }

    public void LoadRandom()
    {
        List<EventSO> biomEvents = new List<EventSO>();
        foreach(EventSO biomEvent in events)
        {
            if(biomEvent.EventType == eventToLoad.EventToLoadSO.EventToLoad)
            {
                biomEvents.Add(biomEvent);
            }
        }
        int loadIndex = UnityEngine.Random.Range(0, biomEvents.Count);
        loadFromSo.Load(biomEvents[loadIndex]);
        currentEvent.CurrentEventSO = biomEvents[loadIndex];
    }
}
