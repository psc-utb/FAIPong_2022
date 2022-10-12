using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetovaniPozice : MonoBehaviour
{
    [SerializeField]
    Vector2 pozicePoResetu;

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
        collider2D.gameObject.transform.position = pozicePoResetu;
    }
}
