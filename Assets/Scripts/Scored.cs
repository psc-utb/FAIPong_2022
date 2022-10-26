using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Scored : MonoBehaviour
{
    [SerializeField]
    private int points = 1;

    public UnityEvent<int> ScoredEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        ScoredEvent?.Invoke(points);
    }
}
