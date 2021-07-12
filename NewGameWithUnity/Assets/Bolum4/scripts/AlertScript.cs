using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertScript : MonoBehaviour
{

   
    [SerializeField] Animator animator;


    public void Update()
    {
        if (Bocek.BocekisDead)
        {   
            
        
            animator.SetBool("takethebug", true);
           
        }
        
    }
}
