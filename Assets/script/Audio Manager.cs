using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
    
{
    public AudioSource BgmAudioSource;
    public GameObject SfxAudioSource;

    private void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        BgmAudioSource.Play();
    }

    public void playSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(SfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
