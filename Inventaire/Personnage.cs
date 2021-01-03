using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personnage : MonoBehaviour
{
    public int PV_max = 5;
    private int PV_actuel;

    public GameObject[] mes_coeurs;


    // Start is called before the first frame update
    void Start()
    {
        PV_actuel = PV_max;
        AfficherPV();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AjouterPV(int valeur) 
    {
        PV_actuel += valeur;
        PV_actuel = Mathf.Clamp(PV_actuel, 0, 5);
        AfficherPV();
    }

    void AfficherPV() 
    {
        for(int i =0; i<PV_max; i++) 
        {
            bool activer = (i < PV_actuel);
            mes_coeurs[i].SetActive(activer);
        }
    }
}
