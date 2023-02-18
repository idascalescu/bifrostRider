using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //Main menu script
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true); //set the gameobject active
    }
    public void PlayGame()
    {
        gameObject.SetActive(false);//the play button will set the gameobject to not active
    }
    public void SetExit()
    {
        Debug.Log("Good Bye");
        Application.Quit();
    }
}
