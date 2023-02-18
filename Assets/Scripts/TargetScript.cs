using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TargetScript : MonoBehaviour
{
    //Variables
    Rigidbody rbd;

    [SerializeField]
    float enemyHealthPoints;

    [SerializeField]
    float explosionForce;
    [SerializeField]
    float explosionRadius;
    [SerializeField]
    float upwardsModifier;

    int countDestroyedAsteroids;

    [SerializeField]
    TextMeshProUGUI DestroyedTextAsteroids;

    private void Start()
    {
        rbd = GetComponent<Rigidbody>();
        countDestroyedAsteroids = 0;//set value 0 for the number of asteroids shot.
    }

    public void EnemyDamaged(float dmgDone)
    {
        enemyHealthPoints -= dmgDone;
        if (enemyHealthPoints <= 0.0f)
        {
            countDestroyedAsteroids +=1;//increae the score with 1 for every asteroid destroyed
            setCountTextAsteroids();
            GetDestroyed();
            ExplForce();
        }
        void GetDestroyed()
        {
            Destroy(gameObject, 1.0f);
        }
    }
    private void ExplForce()
    {
        rbd.AddExplosionForce(explosionForce, transform.position, explosionRadius, upwardsModifier, ForceMode.Force);// add explosion force
    }
    private void setCountTextAsteroids()
    {
        DestroyedTextAsteroids.text ="Score: " + countDestroyedAsteroids.ToString();//score text for destroying the asteroids
    }
}
