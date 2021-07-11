using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses : MonoBehaviour
{
    public static bool control = false;
    private void Start()
    {
        control = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "hero")
        {
            Destroy(this.gameObject);
            control = true;
        }
        

    }

}
