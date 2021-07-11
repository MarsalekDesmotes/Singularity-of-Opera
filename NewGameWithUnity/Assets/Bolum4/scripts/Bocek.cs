using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bocek : MonoBehaviour
{
    public static bool BocekisDead = false;

    private void Start()
    {
        BocekisDead = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "hero")
        {
            BocekisDead = true;
            Destroy(this.gameObject);
        }


    }
}
