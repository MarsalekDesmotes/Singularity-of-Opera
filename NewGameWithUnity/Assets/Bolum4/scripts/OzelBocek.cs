using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OzelBocek : MonoBehaviour
{
    public static bool BocekisDead = false;
    public AudioSource alarm;

    private void Start()
    {
        BocekisDead = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "hero")
        {

            alarm.Play();
            BocekisDead = true;
            Destroy(this.gameObject);
            
        }


    }
}
