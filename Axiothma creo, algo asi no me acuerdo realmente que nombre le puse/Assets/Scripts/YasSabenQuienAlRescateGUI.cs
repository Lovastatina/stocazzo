using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class YasSabenQuienAlRescateGUI : MonoBehaviour
{
    public Shi mainCharacter;
    public GameObject repeat;
    public GameObject slow;
    public GameObject fast;

    bool slowTime = false;
    bool fastTime = false;
    bool morto = false;


    // Separazione

    public static YasSabenQuienAlRescateGUI Instancia;

    public GameObject grupoPrompt;
    public Text etitquetaAzione;

    //
    void Start()
    {
        Instancia = this;
    }

    private void OnEnable()
      {
        Shi.tecnicamenteNoSeMuereSoloReinicia += activarMenu;
        
       
    }

    private void OnDisable()
      {
        Shi.tecnicamenteNoSeMuereSoloReinicia -= activarMenu;
      
       
    }


    public void activarMenu()
      {
        repeat.SetActive(true);
        slow.SetActive(false);
        fast.SetActive(false);
        morto = true;
    }

    public void MostrarInteraccionObj(ObjGenerico elObj)
    {
        if (elObj != null)
        {
            etitquetaAzione.text = elObj.textoAzione;
            grupoPrompt.SetActive(true);
        }

        else
        {
            grupoPrompt.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && fastTime == false && morto == false)
        {

            slow.SetActive(true);
            slowTime = true;
        }

        else if (Input.GetButton("Fire2") && slowTime == false && morto == false)
        {
            fast.SetActive(true);
            fastTime = true;
        }

        else
        {
            slowTime = false;
            fastTime = false;
            slow.SetActive(false);
            fast.SetActive(false);
            
        }
    }
}
