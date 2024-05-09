using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBoard : MonoBehaviour
{

    public AudioSource audioSource;
    [SerializeField] public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //void mediaPlayer(){

            if (Input.GetKeyDown(KeyCode.Alpha1)){
                audioSource.Play();
            } else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                audioSource.Stop();
            } else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                audioSource.Pause();
            }
      //  }
    }
}
