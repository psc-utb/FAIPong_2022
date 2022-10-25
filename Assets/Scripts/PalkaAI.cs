using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalkaAI : MonoBehaviour
{
    [SerializeField]
    GameObject target;

    [SerializeField]
    float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            float rozdilPozic = target.transform.position.y - this.transform.position.y;
            this.transform.Translate(0, rozdilPozic * speed * Time.deltaTime, 0);
        }
    }
}
