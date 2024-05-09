using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] public AudioClip playerJump;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.AudioClip playerJump =audioSource.clip;
        audioSource.GetComponent<AudioSource>();
    }

    public void playPlayerJump()
    {
        audioSource.PlayOneShot(playerJump);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
