using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSet : MonoBehaviour
{
    int Waktu=10;
    float s;
    public Text TextTimer;
    public bool GameActive = true;
    public GameObject CanvasKalah;
    public GameObject CanvasMenang;
    public Text ScorePemain;
    int pt = 0;
    public Text TargetScore;
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
    void OnTargetScore()
    {
        if (pt >= 0)
        {
            int get = 100;
            TargetScore.text = get.ToString("0");
        }
        if (pt >= 100)
        {
            int get = 200;
            TargetScore.text = get.ToString("0");
        }
        if (pt >= 200)
        {
            int get = 400;
            TargetScore.text = get.ToString("0");
        }
        if (pt >= 400)
        {
            int get = 800;
            TargetScore.text = get.ToString("0");
        }
    }
    void OnScore()
    {
        ScorePemain.text = pt.ToString("0");

    }

    // Update is called once per frame
    void Update()
    {
        if (GameActive)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                pt += 25;
                s = 0;
            }
        }
        if(GameActive && Waktu <= 0 && pt>=100)
        {
            Debug.Log("YOU win");
            CanvasMenang.SetActive(true);
            GameActive = false;
        }
        if (GameActive && Waktu <= 0 && pt < 100)
        {
            Debug.Log("Game Over");
            CanvasKalah.SetActive(true);
            GameActive = false;
        }
        setText();
        OnScore();
        OnTargetScore();

    }
    
}
