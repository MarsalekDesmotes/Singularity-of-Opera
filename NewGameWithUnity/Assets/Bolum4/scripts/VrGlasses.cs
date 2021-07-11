using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrGlasses : MonoBehaviour
{
   [SerializeField] SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();


    }

    private void Update()
    {
        if(Glasses.control == true)
        {
            spriteRenderer.color  = new Color(spriteRenderer.color.r, spriteRenderer.color.g , spriteRenderer.color.b , 1f);

            
        }
    }

}
