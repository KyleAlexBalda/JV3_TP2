using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objet_detection : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private AudioClip _audioClip;
    

    
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    
    private void OnParticleCollision(GameObject other){
        
        _audioSource.clip = _audioClip;
        _audioSource.Play();
    }
}
