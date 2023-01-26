using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource source;
    public AudioClip[] sounds;
    void Start()
    {
        source=GetComponent<AudioSource>();
        int rad=Random.Range(0,sounds.Length);
        source.clip=sounds[rad];
        source.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
