using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnShipCollision : MonoBehaviour
{
    [SerializeField]
    Transform Ship;
    [SerializeField]
    Transform RespawnPoint;

    private void OnCollisionEnter(Collision collision)//when the ship will collide with any object where this script is attached
        //the ship will be respawn back to the start point
    {
        Ship.transform.position = RespawnPoint.transform.position;
    }
}
