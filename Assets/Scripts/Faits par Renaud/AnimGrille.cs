using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AnimGrille : MonoBehaviour
{

    [SerializeField] private InfosJoueur _infosJoueur;

    private Animator _animator;

    private AudioSource audioSource;

    //Vérifie si la porte est déjà ouverte
    private bool _estOuvert = true;


    // Start is called before the first frame update
    void Start()
    {
        // Récupère le composant Animator
        _animator = GetComponent<Animator>();

        // Récupère le composant AudioSource
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        if(_estOuvert==true){
            ouvreGrille();   
        }
        
    }
    private void ouvreGrille(){
        if(_infosJoueur._nbPointsTotaux == 3){
            Debug.Log("C'est ouvert");
            animGrille();

            audioSource.Play();
            _estOuvert=false;
        }
    }
    public void animGrille(){
        _animator.SetBool("ouvre",true); 
    }
}
