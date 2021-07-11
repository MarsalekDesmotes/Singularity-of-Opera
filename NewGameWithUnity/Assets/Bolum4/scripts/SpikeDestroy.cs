using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDestroy : MonoBehaviour
{

    private void Update()
    {
        if (Bocek.BocekisDead)
        {
            Destroy(this.gameObject);
        }
    }

}
