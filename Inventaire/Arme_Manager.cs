using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arme_Manager : MonoBehaviour
{
    public Arme[] mes_armes;
    public Text mon_affichage_texte;
    public Image mon_affichage_image;

    void Start() 
    {
        
        AfficherArme(-1);
    }


    public void AssignerArme(int num_de_l_arme) 
    {
        AfficherArme(num_de_l_arme);
    }

    public void AfficherArme(int num_de_l_arme) 
    {
        if (num_de_l_arme < 0) 
        {
            mon_affichage_image.sprite = null;
            mon_affichage_texte.text = "Arme actuelle : aucune \n Puissance: 0";
        }
        else 
        {
            mon_affichage_image.sprite = mes_armes[num_de_l_arme].mon_image;
            mon_affichage_texte.text = "Arme actuelle :"+ mes_armes[num_de_l_arme].mon_nom +"\nPuissance:"+ mes_armes[num_de_l_arme].attaque.ToString() ;
        }
    }


}
