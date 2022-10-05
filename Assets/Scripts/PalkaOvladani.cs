using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalkaOvladani : MonoBehaviour
{
    [Tooltip("rychlost p�lky")]
    [SerializeField]
    private float rychlost = 1f;

    [Tooltip("kl�vesa pro pohyb nahoru")]
    [SerializeField]
    private KeyCode KeyUp = KeyCode.W;

    [Tooltip("kl�vesa pro pohyb dol�")]
    [SerializeField]
    private KeyCode KeyDown = KeyCode.S;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyUp))
        {
            Vector3 zmenaPozice = new Vector3(0, rychlost * Time.deltaTime, 0);
            this.transform.Translate(zmenaPozice);
        }

        if (Input.GetKey(KeyDown))
        {
            Vector3 zmenaPozice = new Vector3(0, -rychlost * Time.deltaTime, 0);
            this.transform.Translate(zmenaPozice);
        }
    }
}
