using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    //VARS//
    public float shootingRate;
    private float muzzleShootingRate;

    public float canonDamage = 10.0f;

    public GameObject shootPrefab;

    RaycastHit hitthat;

    float cannonRange = 1000.0f;
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time > muzzleShootingRate)
            {
                shootRay();
                muzzleShootingRate = Time.time + shootingRate;

            }
        }
    }

    void shootRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitthat, cannonRange))
        {
            GameObject Laser = GameObject.Instantiate(shootPrefab, transform.position, transform.rotation) as GameObject;
            Laser.GetComponent<ShotBehavior>().setTarget(hitthat.point);
            GameObject.Destroy(Laser, 0.6f);
            TargetScript target = hitthat.transform.GetComponent<TargetScript>();
            if (target != null)
            {
                target.EnemyDamaged(canonDamage);
            }
            Debug.Log(hitthat.transform.name);
        }
    }
}
   
