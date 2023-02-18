using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CollisionScript : MonoBehaviour
{
    //Variables
    private float shipHP;
     
    [SerializeField]
    EndLevelScript endLevelScript;

    ShipMovement shipMovement;

    [SerializeField]
    TextMeshProUGUI PickUpCoins;

    int countCoins;
    bool allCoinsCollected;

    // Start is called before the first frame update
    void Start()
    {
        shipHP = 100.0f;
        countCoins = 0;//set value of countCoins to 0
    }

    // Update is called once per frame
    void Update()
    {
        if (shipHP == 0)
        {
            Debug.Log(" You lost you're ship captain .. ... .. ");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            shipHP -= 100;
        }
        if(collision.gameObject.tag == "endofgame" && allCoinsCollected == true)// only if the player collected all the coins he will be able to pas through the gate
        {
            endLevelScript.gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)//Trigger enter collision for collecting the coins
    {
        if (other.gameObject.layer == 8)
        {
            countCoins += 1;
            SetCountCoins();
            if (countCoins == 3)
            {
                allCoinsCollected = true;
            }
            Destroy(other.gameObject);
        }
    }

    private void SetCountCoins()
    {
        PickUpCoins.text = "Coins: " + countCoins.ToString();
    }
}

