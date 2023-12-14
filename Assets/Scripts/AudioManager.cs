using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void AjusteVolumeMusique(float volume){

        audioMixer.SetFloat("VolumeMusique",volume);

    }
    public void AjusteVolumeEffets(float volume){

        audioMixer.SetFloat("VolumeEffets",volume);

    }
}
