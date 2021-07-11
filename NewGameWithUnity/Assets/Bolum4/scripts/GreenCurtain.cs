using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCurtain : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    float slowly;
    private void Update()
    {
        if (Glasses.control == true)
        {
            if (slowly < 1)
            {
                slowly += Time.deltaTime;
                
            }

            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, slowly);
        }
    }
}
