using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float rand;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 0.2f);
    }
    void GoBall()
    {
        rand = Random.Range(0, 2);
        if (rand == 0)
        {
            rb2d.AddForce(new Vector2(40, -22));
        }
        else
        {
            rb2d.AddForce(new Vector2(-40, -22));
        }
    }

    public void Restart()
    {
        Debug.Log("Game Restarted");
        Reset();
        Invoke("GoBall", 0.1f);
    } 
    private void Reset()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }
}
