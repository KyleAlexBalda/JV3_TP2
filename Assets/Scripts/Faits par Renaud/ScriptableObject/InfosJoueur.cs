using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosJoueur", menuName = "SO/InfosJoueur")]
public class InfosJoueur : ScriptableObject
{
    //Contient le nombre de points actuels
    public int _nbPoints;

    //Contient le nombre de points totaux
    public int _nbPointsTotaux;
}
