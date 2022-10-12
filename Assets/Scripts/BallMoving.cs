using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallMoving : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;

    [Range(1f, 5f)]
    [SerializeField]
    float Silax = 1f;

    [Range(1f, 5f)]
    [SerializeField]
    float Silay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();

        float levaPrava = Random.Range(0.0f, 1.0f);
        float horniDolni = Random.Range(0.0f, 1.0f);

        if (levaPrava < 0.5 && horniDolni < 0.5)
        {
            m_Rigidbody.AddForce(new Vector2(-Silax, Silay));
        }
        else if (levaPrava < 0.5 && horniDolni >= 0.5)
        {
            m_Rigidbody.AddForce(new Vector2(-Silax, -Silay));
        }
        else if (levaPrava >= 0.5 && horniDolni < 0.5)
        {
            m_Rigidbody.AddForce(new Vector2(Silax, Silay));
        }
        else
        {
            m_Rigidbody.AddForce(new Vector2(Silax, -Silay));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
