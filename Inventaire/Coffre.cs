 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coffre : MonoBehaviour
{

    [HideInInspector]public int mon_arme;
    [HideInInspector] public int mon_objet;

    public Image affichage_arme;
    public Image affichage_objet;

    public ObjetsConsomables l_inventaire;

    public Arme_Manager les_armes;

    // Start is called before the first frame update
    void Start()
    {
        OuvrirLeCoffre();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OuvrirLeCoffre() 
    {
        float r = Random.value;
        if (r < 0.3f) 
        {
            affichage_arme.gameObject.SetActive(true);
            affichage_objet.gameObject.SetActive(false);

            mon_arme = Random.Range(0, 3);
            affichage_arme.sprite = les_armes.mes_armes[mon_arme].mon_image;
        }
        else 
        {
            affichage_arme.gameObject.SetActive(false);
            affichage_objet.gameObject.SetActive(true);

            mon_objet = Random.Range(0, 3);
            affichage_objet.sprite = l_inventaire.mon_inventaire[mon_objet].icone_objet;
        }
    }

    

    public void PrendreArme() 
    {
        affichage_arme.sprite = null;
        les_armes.AssignerArme(mon_arme);
        affichage_arme.gameObject.SetActive(false);
    }

    public void PrendreObjet()
    {
        affichage_objet.sprite = null;
        string nomObjet = l_inventaire.mon_inventaire[mon_objet].nom_objet;
        l_inventaire.GagnerObjet(nomObjet,1);
        affichage_objet.gameObject.SetActive(false);

    }
}
