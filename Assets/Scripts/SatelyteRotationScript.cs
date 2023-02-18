using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelyteRotationScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, -1.2f, 0);//The gameobject will rotate opposite the orbiting direction 
        //to create a better effect
    }
}
