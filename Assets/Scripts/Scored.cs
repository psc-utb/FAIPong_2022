using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scored : MonoBehaviour
{
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
        if (collider2D.gameObject.tag == "BranaLeva")  //<><>
        {
            GameManager.Instance.ZvysScoreHrace2();
        }
        else if (collider2D.gameObject.tag == "BranaPrava")  //<><>
        {
            GameManager.Instance.ZvysScoreHrace1();
        }
    }
}
