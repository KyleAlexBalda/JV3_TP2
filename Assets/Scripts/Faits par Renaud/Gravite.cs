using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravite : MonoBehaviour
{
    //Script de YoungDeveloper
    //Trouvé à l'adresse suivante : https://discussions.unity.com/t/how-to-make-an-object-float-in-space/79357
    //Utilisé pour que l'objet flotte dans les airs


    public float FloatStrenght;
	public float RandomRotationStrenght;
	
	
	void Update () {
		transform.GetComponent<Rigidbody>().AddForce(Vector3.up *FloatStrenght);
		 transform.Rotate(RandomRotationStrenght,RandomRotationStrenght,RandomRotationStrenght);
	}
}
