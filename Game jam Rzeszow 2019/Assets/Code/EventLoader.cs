using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLoader : MonoBehaviour
{
    [SerializeField]
    private List<EventSO> events = new List<EventSO>();

    private LoadFromSO loadFromSo;

    private void Start()
    {
        loadFromSo = FindObjectOfType<LoadFromSO>();
        loadFromSo.Load(events[0]);
    }
}
