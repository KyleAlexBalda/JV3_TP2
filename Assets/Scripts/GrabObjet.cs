using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObjet : MonoBehaviour
{
    /// <summary>
    /// Ce script est utilisé pour le pointage
    /// </summary>


    [SerializeField] private InfosJoueur _infosJoueur;
    [SerializeField] private int _nbPoints;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Score"){

            //Enregistre le nombre de point(s) actuel(s)
            _infosJoueur._nbPoints += _nbPoints;


            //Enregistre le nombre de points totaux
            _infosJoueur._nbPointsTotaux += _nbPoints;

           //Enlève l'objet de la scène
            Destroy(other);
        }
            
    }
}
