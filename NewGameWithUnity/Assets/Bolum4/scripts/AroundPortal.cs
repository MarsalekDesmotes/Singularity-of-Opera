using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundPortal : MonoBehaviour
{
    private void Update()
    {
        if (Bocek.BocekisDead)
        {
            Destroy(this.gameObject);
        }
    }
}
