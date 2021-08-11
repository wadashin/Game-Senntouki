using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audio;

    //int n = 0;
    float time = 0;
    public AudioClip sound01;
    //public AudioClip sound02;
    //public AudioClip sound03;

    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time == 0)
        {
            audio.PlayOneShot(sound01);
        }
        if (time >= 1680)
        {
            time = 0;
        }
        time++;
    }
}
