﻿using UnityEngine;

public class AndroidCollision : MonoBehaviour
{

    public AndroidMovement movement;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}