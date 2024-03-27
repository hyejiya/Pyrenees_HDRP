using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private void Start()
    {
        Invoke("PlayBallSFX", 3f);
        Invoke("PlayTextSFX", 3f);
    }

    public void PlayBallSFX()
    {
        AudioSource ballSFX = GameObject.Find("SoundManager/BallSFX").GetComponent<AudioSource>();
        ballSFX.Play();
    }

    public void PlayTextSFX()
    {
        AudioSource textSFX = GameObject.Find("SoundManager/TextSFX").GetComponent<AudioSource>();
        textSFX.Play();
    }
}
