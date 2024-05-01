using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : ObjGenerico
{
    private Animator miAnimador;
    private bool abierto = false;
    public GameObject siguiente;


    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    public override void ActivareAzione()
    {
        if (abierto == false)
        {
            miAnimador.SetTrigger("Abrire");
            textoAzione = "Abrir la puerta";
            siguiente.SetActive(true);
        }

        else
        {
            miAnimador.SetTrigger("Cerrar");
            textoAzione = "Cerrar la puerta";
        }
        abierto = !abierto;
    }
}



