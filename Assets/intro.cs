using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx;
    void Start()
    {
        src.clip = sfx;
        src.Play();
    }
}
