using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public GameObject areaAnterior;
    public Porta laPuerta;
    private Animator laAnimatore;
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            laAnimatore.SetTrigger("Cerrar");

            Destroy(areaAnterior, 2f) ;


            GetComponent<BoxCollider>().enabled = false;
            Destroy(gameObject, 2.1f);

            
        }
    }


    




    void Start()
    {
        laAnimatore = laPuerta.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
