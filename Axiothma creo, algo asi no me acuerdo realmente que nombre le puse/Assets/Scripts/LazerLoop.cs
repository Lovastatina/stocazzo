using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LazerLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("apagarLaser", 0.25f, 0.5f);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject otroObjeto = other.gameObject;

        if (otroObjeto.tag == "Player")
        {
            print("Parsing");

            Invoke("repito", 0.035f);
            Time.timeScale = 0.025f;

        }
    }

    private void apagarLaser()
    {
        gameObject.SetActive(false);

        Invoke("encenderLaser", 0.25f);
    }

    private void encenderLaser()
    {
        gameObject.SetActive(true);
    }


    private void repito()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
