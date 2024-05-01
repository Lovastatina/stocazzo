using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movGiocatore : MonoBehaviour
{
    public float zenX;
    public float zenY;
    public Transform orientazione;
    float rotX;
    float rotY;
    bool slowTime = false;
    bool fastTime = false;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        float giroX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * zenX;
        float giroY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * zenY;

        rotX -= giroY;
        rotY += giroX;
        rotX = Mathf.Clamp(rotX, -90f, 90f);

        transform.rotation = Quaternion.Euler(rotX, rotY, 0);
        orientazione.rotation = Quaternion.Euler(0, rotY, 0);

        if (Input.GetButton("Fire1") && fastTime == false)
            {
                zenX = 3600f;
                zenY = 3600f;
                slowTime = true;
            }

        else if (Input.GetButton("Fire2") && slowTime == false)
        {
            zenX = 180f;
            zenY = 180f;
            fastTime = true;
        }

        else
        {
            zenX = 700f;
            zenY = 700f;
            slowTime = false;
            fastTime = false;
        }

        

      

    }
}
