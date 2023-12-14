using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Porte_nico : MonoBehaviour
{
    [SerializeField] private GameObject porte;
    [SerializeField] private AudioSource son;

     


     private Animator  animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = porte.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimationPorte(){

    animation.SetBool("New Bool",true); 
}
void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("weapon"))
    {
        Destroy(other.gameObject);
        AnimationPorte();

        son.Play();
    }
}

}
