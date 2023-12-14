using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimGrille : MonoBehaviour
{
    [SerializeField] private GameObject _grille;

    [SerializeField] private InfosJoueur _infosJoueur;

    private Animator animation;


    // Start is called before the first frame update
    void Start()
    {
        animation = _grille.GetComponent<Animator>();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        ouvreGrille();
    }
    private void ouvreGrille(){
        if(_infosJoueur._nbPointsTotaux == 3){
            Debug.Log("C'est ouvert");
            animGrille();
        }
    }
    public void animGrille(){
        animation.SetBool("ouvre",true); 
    }
}
