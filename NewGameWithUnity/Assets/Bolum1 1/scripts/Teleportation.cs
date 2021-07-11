using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{ 
    public GameObject player,orange,blue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(gameObject.tag == "orange")
        {
            if(collision.gameObject.tag == "hero")
        {
            StartCoroutine(TeleportO());

        }

        }
       if(gameObject.tag == "blue")
        {

           if(collision.gameObject.tag == "hero")
            {
                StartCoroutine(TeleportB());

            }

        }
    }

    IEnumerator TeleportO()
    {
        yield return new WaitForSeconds(1);
       player.transform.position = new Vector2(blue.transform.position.x + 10, blue.transform.position.y);


    }


    IEnumerator TeleportB()
    {
        yield return new WaitForSeconds(1);
        player.transform.position = new Vector2(orange.transform.position.x+10, orange.transform.position.y);


    }
}
