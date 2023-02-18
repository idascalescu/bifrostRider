using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCoinScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0.0f, 1.2f, 0.0f)/Time.deltaTime);// the gameobject will rotate on the Y axis.
    }
}
