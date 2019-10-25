using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLoader : MonoBehaviour
{
    [SerializeField]
    private List<EventSO> events = new List<EventSO>();

    private LoadFromSO loadFromSo;
    private CurrentEvent currentEvent;

    private void Start()
    {
        currentEvent = FindObjectOfType<CurrentEvent>();
        loadFromSo = FindObjectOfType<LoadFromSO>();
        LoadRandom();
    }

    public void LoadRandom()
    {
        int loadIndex = UnityEngine.Random.Range(0, events.Count);
        loadFromSo.Load(events[loadIndex]);
        currentEvent.CurrentEventSO = events[loadIndex];
    }
}
