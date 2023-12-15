using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ouvrir_porte : MonoBehaviour
{
    [SerializeField] private GameObject _porte;

    [SerializeField] private InfosJoueur _infosJoueur;

    private Animator _animator;

    [SerializeField] private AudioSource _son;

    private bool _pointsPris = false;


    // Start is called before the first frame update
    void Start()
    {
        // Récupère le composant Animator
        _animator = GetComponent<Animator>();
        _pointsPris = false;
    }

    private void Update()
    {
        ouvrePorte();
    }
    private void ouvrePorte(){
        if(_infosJoueur._nbPointsTotaux == 8 && _pointsPris == false){
            Debug.Log("C'est ouvert");
            animPorte();
            _son.Play();
            _pointsPris = true;
        }
    }
    public void animPorte(){
        _animator.SetBool("porte_ouvre",true); 
    }


}
