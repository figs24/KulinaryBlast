using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMusic : MonoBehaviour
{
    public AudioSource lagu1, lagu2;
    public Slider volumeMusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        if (gameObject.name == "Tombol lagu 1")
        {
            lagu1.Play();
            lagu2.Stop();
            lagu1.volume = volumeMusic.value;
        }
        else
        {
            lagu1.Stop();
            lagu2.Play();
            lagu2.volume = volumeMusic.value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
