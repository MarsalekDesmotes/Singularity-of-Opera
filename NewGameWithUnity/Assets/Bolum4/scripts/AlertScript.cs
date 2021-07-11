using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertScript : MonoBehaviour
{
    [SerializeField] Animator animator;
    private void Update()
    {
        if (Bocek.BocekisDead)
        {
            animator.SetBool("takethebug", true);
        }
        
    }
}
