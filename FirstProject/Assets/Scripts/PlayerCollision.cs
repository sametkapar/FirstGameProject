using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    //public GameManager GameManager;
   void OnCollisionEnter (Collision collisionInfo1)
    {
        //Debug.Log("We hit something!");
        if (collisionInfo1.collider.tag == "Obstacle")
        {
            //Debug.Log("You hit an obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
           
        }
    }

}
