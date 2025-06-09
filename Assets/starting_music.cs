using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starting_music : MonoBehaviour
{

    public AudioSource src;
    public AudioClip sfx;
    // Start is called before the first frame update
    void Start()
    {
        src.clip = sfx;
        src.Play();
    }
}
