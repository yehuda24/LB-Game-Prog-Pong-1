using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, 0f); // set y velocity to zero
        rb2d.AddForce(new Vector2(0f, 300f));
    }
}
