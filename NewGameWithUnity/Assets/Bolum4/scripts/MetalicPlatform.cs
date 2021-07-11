using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalicPlatform : MonoBehaviour
{

    [SerializeField] BoxCollider2D BoxCollider2D;

    [SerializeField] SpriteRenderer spriteRenderer;

    float slowly;

    private void Start()
    {
        BoxCollider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(Glasses.control == true)
        {
            if (slowly < 1)
            {
                slowly += Time.deltaTime * 0.2f;
            }
            
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, slowly);
        }
    }

}
