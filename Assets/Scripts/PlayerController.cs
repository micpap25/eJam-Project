﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public Rigidbody2D rb;
     public int numBalloons;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space) && numBalloons > 0)
        {
           numBalloons--;
        }
        float value = -1.5f + (.75f * numBalloons);
        if (rb.velocity.y < value) {
            rb.velocity = new Vector2 (rb.velocity.x, value);
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Collectable"))
        {
            col.gameObject.GetComponent<Collectable>().collide();
        }

        if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.CompareTag("UpperBoundary"))
        {
            numBalloons--;
        }

    }
}
