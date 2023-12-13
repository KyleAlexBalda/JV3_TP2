using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GrabObjet : MonoBehaviour
{
    /// <summary>
    /// Ce script est utilisé pour le pointage
    /// À utiliser sur les objects qu'on veut récolter
    /// </summary>


    [SerializeField] private InfosJoueur _infosJoueur;
    [SerializeField] private int _nbPoints = 1;


    //Nombre de secondes avant que l'objet disparaisse
    [SerializeField] private int _timerDestroy = 1;


    //Variables pour le son
    [SerializeField] private AudioClip _sonDetruit;
    private AudioSource audioSource;

    void Start()
    {
        // Récupère le composant AudioSource
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            Debug.Log("collision");

            //Joue un son lorsque l'objet est touché
            audioSource.clip = _sonDetruit;
            audioSource.Play();

           //Enlève l'objet de la scène dans X secondes
            Invoke("DetruitObjet", _timerDestroy);
        }
            
    }
    private void DetruitObjet(){
        //Enregistre le nombre de point(s) actuel(s)
        _infosJoueur._nbPoints += _nbPoints;

        //Enregistre le nombre de points totaux
        _infosJoueur._nbPointsTotaux += _nbPoints;

        Destroy(gameObject);
    }
}
