using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloJNoMarques : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.V))
        {
            Time.timeScale = 0.2f;

            Debug.Log(Time.timeScale);

        }

        else
        {
            Time.timeScale = 1f;
        }

        


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
