using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPlayer : MonoBehaviour
{
    [Header("Mov")]
    public float vel;
    public float agarrePiso;
    public float salto;
    public float saltoCoolAbajo;
    public float aire;
    bool listoSalto = true;
    public float multGravedad = 1f;
    public float distToGround;
    

    [Header("En Piso")]
    public float altura;
    public LayerMask piso;
    bool enPiso;

    public Transform orient;
    float movX;
    float movY;
    Vector3 movDireccion;
    Rigidbody miCuerpo;

    private void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miCuerpo.freezeRotation = true;
	distToGround = GetComponent<Collider>().bounds.extents.y;
    }

	
    private void caminar()
    {
        movDireccion = orient.forward * movY + orient.right * movX;
        if (enPiso)
        {
           miCuerpo.AddForce(movDireccion.normalized * vel * 10, ForceMode.Force);
        }

        else if (!enPiso)
        {
            miCuerpo.AddForce(movDireccion.normalized * vel * 20 * aire, ForceMode.Force);
        }
        
    }

    private void limitar()
    {
        Vector3 flatVel = new Vector3(miCuerpo.velocity.x, 0f, miCuerpo.velocity.z);

        if(flatVel.magnitude > vel)
        {
            Vector3 limitedVel = flatVel.normalized * vel;
            miCuerpo.velocity = new Vector3(limitedVel.x, miCuerpo.velocity.y, limitedVel.z);
        }
    }

    private void saltar()
    {
        miCuerpo.velocity = new Vector3(miCuerpo.velocity.x, 0, miCuerpo.velocity.z);
        miCuerpo.AddForce(transform.up * salto, ForceMode.Impulse);

    }

    private void resetearSalto()
    {
        listoSalto = true;
    }
        
    private void Update()
    {
        enPiso = Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);

	
	
        movX = Input.GetAxisRaw("Horizontal");
        movY = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.Space) && listoSalto && enPiso)
        {
            listoSalto = false;
            saltar();
            Invoke(nameof(resetearSalto), saltoCoolAbajo);

        }

        limitar();

        if (enPiso)
        {
            miCuerpo.drag = agarrePiso;
	   
        }

        else
        {
            miCuerpo.drag = 0;
        }

        if (Input.GetKey(KeyCode.V))
        {
            vel = 48f;
            agarrePiso = 12f;
        }

        else
        {
            vel = 5f;
            agarrePiso = 5f;
        }


    }



    private void FixedUpdate()
    {
        caminar();
	miCuerpo.AddForce(Physics.gravity);

        
    }


}

