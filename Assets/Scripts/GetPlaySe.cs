using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlaySe : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioPlayer audioPlayer;
    [SerializeField] private float Volume = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        if (audioPlayer == null)
        {
            audioPlayer = FindObjectOfType<AudioPlayer>();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        audioPlayer.PlayAudio(audioClip, Volume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
