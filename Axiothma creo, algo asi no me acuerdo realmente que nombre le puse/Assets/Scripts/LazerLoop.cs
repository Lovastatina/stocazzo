using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("apagarLaser", 1f, 2f);
        
    }

    

    private void apagarLaser()
    {
        gameObject.SetActive(false);

        Invoke("encenderLaser", 1f);
    }

    private void encenderLaser()
    {
        gameObject.SetActive(true);
    }


}
