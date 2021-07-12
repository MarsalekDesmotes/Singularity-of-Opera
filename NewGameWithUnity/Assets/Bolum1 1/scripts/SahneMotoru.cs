using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneMotoru : MonoBehaviour
{
  public void Bolum4Gecis()
    {

        SceneManager.LoadScene("Main");

    }


    public void optionsGecis()
    {

        // SceneManager.LoadScene("Options");

    }


    public void exitGecis()
    {
        Application.Quit();


    }


    public void menuGecis()
    {
        SceneManager.LoadScene("Main Menu");


    }

    public void sonGecis()
    {
        SceneManager.LoadScene("Son");


    }





    private void OnCollisionEnter2D(Collision2D collision)
    {


        if(collision.gameObject.tag == "hero")
        {
    
        Debug.Log("spacegetti");
        Bolum4Gecis();

        }
       


    }





}
