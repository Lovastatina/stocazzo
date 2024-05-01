using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloJNoMarques : MonoBehaviour
{

    bool slowTime = false;
    bool fastTime = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1") && fastTime == false)
        {
            Time.timeScale = 0.2f;

            Debug.Log(Time.timeScale);
            slowTime = true;

        }

        else if (Input.GetButton("Fire2") && slowTime == false)
        {
            Debug.Log(Time.timeScale);
            Time.timeScale = 1.8f;
            fastTime = true;
        }

        else
        {
            Time.timeScale = 1f;
            slowTime = false;
            fastTime = false;
        }



        





    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
