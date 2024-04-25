using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movKamera : MonoBehaviour
{
    public Transform kameraPos;

  
   
    void Update()
    {
        transform.position = kameraPos.position;
    }
}
