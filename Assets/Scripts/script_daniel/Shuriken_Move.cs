using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken_Move : MonoBehaviour
{

    private Animator _animatore;


     void Start()
    {
        // Récupère le composant Animator
        _animatore = GetComponent<Animator>();
        animShuriken();
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            
        }
    }

    public void animShuriken(){
        _animatore.SetBool("shuriken_mouvement",true); 
    }
}
