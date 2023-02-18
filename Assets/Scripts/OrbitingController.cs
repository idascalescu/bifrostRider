using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingController : MonoBehaviour
{
    //Variables
    [SerializeField]
    float satSpeed = 0.6f;
    [SerializeField]
    float speedRotation = 0.3f;
    [SerializeField]
    Transform orbitCenter;
    [SerializeField]
    float orbitRadius = 5.5f;
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time * satSpeed) * orbitRadius, 0, Mathf.Cos(Time.time * satSpeed) * orbitRadius);
        transform.position += orbitCenter.position;
    }
}
