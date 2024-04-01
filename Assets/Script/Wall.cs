using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.name == "Ball")
        {
            string wallName = transform.name;
            Debug.Log("Wall : " + wallName);
            hitInfo.gameObject.SendMessage("Restart");
            GameManager.Instance.Scoring(wallName);
        }
    }

}
