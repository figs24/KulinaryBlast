using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSet : MonoBehaviour
{
    int Waktu=3;
    public Text TextTimer;
    public bool GameActive = true;
    public GameObject CanvasKalah;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void setText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }
    float s;

    // Update is called once per frame
    void Update()
    {
        if (GameActive)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }
        if(GameActive && Waktu <= 0)
        {
            Debug.Log("Game Over");
            CanvasKalah.SetActive(true);
            GameActive = false;
        }
        setText();
        
    }
    
}
