using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource audioSource;
// Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void PlayAudio(AudioClip audioClip, float volume)
    {
        audioSource.volume = volume;
        audioSource.PlayOneShot(audioClip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
