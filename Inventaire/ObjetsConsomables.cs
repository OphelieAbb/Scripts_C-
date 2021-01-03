using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetsConsomables : MonoBehaviour
{
    [System.Serializable]
    public class ObjetInventaire 
    {
        public string nom_objet;
        public Sprite icone_objet;
        public int qty_objet;
        public int efficacite;
        public Text afficher_qty;

    }

    public ObjetInventaire [] mon_inventaire;
    public Personnage heros;

    void Start()
    {
        GagnerObjet("Pomme", 3);
        GagnerObjet("Potion", 3);
        GagnerObjet("Poison", 3);
    }

    public void GagnerObjet(string nom, int qty) 
    {
        foreach(ObjetInventaire obj in mon_inventaire) 
        {
            if (obj.nom_objet == nom) 
            {
                obj.qty_objet += qty;

                obj.afficher_qty.text = obj.qty_objet.ToString();
            }
        }
    }
    
    public void ConsommerObjet(string nom) 
    {
        foreach (ObjetInventaire obj in mon_inventaire)
        {
            if (obj.nom_objet == nom)
            {
                if (obj.qty_objet > 0) 
                {
                    GagnerObjet(nom, -1);
                    heros.AjouterPV(obj.efficacite);
                }
            }
        }
    }
  
}
