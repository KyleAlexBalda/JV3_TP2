using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private InfosJoueur _infosJoueur;
    [SerializeField] private TMP_Text _score;

    // Update is called once per frame
    void Update()
    {
        //Applique le nb de points actuels dans le canva
        _score.text = _infosJoueur._nbPointsTotaux.ToString();
    }
}
