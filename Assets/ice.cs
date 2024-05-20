using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice : MonoBehaviour
{
    private float f1;
    private float f2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Player>().speed = 0;
                    f1 = collision.GetComponent<Player>().ostx;
                    f2 = collision.GetComponent<Player>().osty;
        }
            
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Player>().rb.velocity = new Vector3(f1, f2, 0);
        }
    }
}
