using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjGenerico : MonoBehaviour
{

    public string textoAzione;
    private bool playerEnContacto = false;

    public abstract void ActivareAzione();

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerEnContacto = true;
            YasSabenQuienAlRescateGUI.Instancia.MostrarInteraccionObj(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerEnContacto = false;
            YasSabenQuienAlRescateGUI.Instancia.MostrarInteraccionObj(null);
        }
    }

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerEnContacto)
        {
            ActivareAzione();


        }
    }
}
