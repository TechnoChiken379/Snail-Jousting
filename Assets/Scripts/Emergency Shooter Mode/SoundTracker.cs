using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTracker : MonoBehaviour
{
    public AudioSource[] soundFX;
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // If you press the button
        {
            soundFX[0].Play(); // It does the sound
        }
    }
}
