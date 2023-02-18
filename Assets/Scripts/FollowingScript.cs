using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingScript : MonoBehaviour
{
    //Variables
    [SerializeField]
    Transform ship;
    [SerializeField]
    Vector3 offSet;

    // Update is called once per frame
    void Update()
    {
        transform.position = ship.position + offSet;
    }
}
