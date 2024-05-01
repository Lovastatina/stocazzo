using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Shi : MonoBehaviour
{


    public static event Action tecnicamenteNoSeMuereSoloReinicia;
    


    private void OnTriggerEnter(Collider lotro)
    {
        
    GameObject otroObjeto = lotro.gameObject;

        if (otroObjeto.tag == "Morte")
        {
            print("Moriste equisde");

            tecnicamenteNoSeMuereSoloReinicia?.Invoke();

        }
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
