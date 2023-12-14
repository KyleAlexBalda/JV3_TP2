using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ouvrir_porte : MonoBehaviour
{
    [SerializeField] private GameObject _porte;

    [SerializeField] private InfosJoueur _infosJoueur;

    private Animator _animator;


    // Start is called before the first frame update
    void Start()
    {
        // Récupère le composant Animator
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        ouvrePorte();
    }
    private void ouvrePorte(){
        if(_infosJoueur._nbPointsTotaux == 8){
            Debug.Log("C'est ouvert");
            animPorte();
        }
    }
    public void animPorte(){
        _animator.SetBool("porte_ouvre",true); 
    }
}
