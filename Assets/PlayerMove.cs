using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float spd;

    private Rigidbody2D rigbody;
    void Start()
    {
        rigbody = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigbody.velocity = new Vector2(-spd, rigbody.velocity.y);
        }
    }
}