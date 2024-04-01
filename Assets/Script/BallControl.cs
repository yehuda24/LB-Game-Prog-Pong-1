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
            rb2d.AddForce(new Vector2(10, -4));
        }
        else
        {
            rb2d.AddForce(new Vector2(-10, -4));
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

    [SerializeField] private int stageCollisionCount;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            rb2d.AddForce(new Vector2(10, -4));
            stageCollisionCount = 0;
        } else if(collision.gameObject.name == "Bear")
        {
            rb2d.AddForce(new Vector2(-10, -4));
            stageCollisionCount = 0;
        }
        else 
        {
            stageCollisionCount++;
            Debug.Log("Stage Collision = " + stageCollisionCount);
            if(stageCollisionCount > 6)
            {
                GoBall();
            }
        }
    }

}
