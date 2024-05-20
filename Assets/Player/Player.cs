using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public int speed;
    public Rigidbody2D rb;
    public int StarterSpeed;
    public float ostx;
    public float osty;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        StarterSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * speed;

        vertical = Input.GetAxis("Vertical") * speed;

        rb.velocity = new Vector3(horizontal, vertical, 0);

        ostx = horizontal;
        osty = vertical;

    }
}

