using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixController : MonoBehaviour
{
    [SerializeField] new ParticleSystem particleSystem;

    public float baslangic=0f;

    public float bitis = 50f;
    private void Start()
    {

        particleSystem = GetComponent<ParticleSystem>();
        var emission = particleSystem.emission;
        emission.rateOverTime = baslangic;


    }


    private void Update()
    {
        if (Bocek.BocekisDead == true)
        {
            var emission = particleSystem.emission;
            emission.rateOverTime = 500f;

            Debug.Log("Buraya girildi");
        }
        
    }



}
