using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour
{
    [SerializeField]
    public float forceRot;//created public accesed float named speedRot//
    void Update()
    {
        transform.Rotate(Mathf.Tan(forceRot), 0.05f, 0.0f);
    }
}