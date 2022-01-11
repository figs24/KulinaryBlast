using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSet : MonoBehaviour
{
    int Waktu=30;
    float s;
    public Text TextTimer;
    public bool GameActive = true;
    public GameObject CanvasKalah;
    public GameObject CanvasMenang;
    private Board board;
    public Text scoreText;
    public Text TargetScore;
    public Text TargetScore1;
    public Text TargetScore2;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        board = FindObjectOfType<Board>();
    }
    void OnTargetScore()
    {
        if (TargetScore)
        {
            if (score >= 0)
            {
                int get = 250;
                TargetScore.text = get.ToString("0");
            }
            if (score >= 250)
            {
                int get = 500;
                TargetScore.text = get.ToString("0");
            }
            if (score >= 500)
            {
                int get = 750;
                TargetScore.text = get.ToString("0");
            }
        }
        if (TargetScore1)
        {
            if (score >= 0)
            {
                int get = 750;
                TargetScore1.text = get.ToString("0");
            }
            if (score >= 750)
            {
                int get = 1000;
                TargetScore1.text = get.ToString("0");
            }
            if (score >= 1000)
            {
                int get = 1250;
                TargetScore1.text = get.ToString("0");
            }
        }
        if (TargetScore2)
        {
            if (score >= 0)
            {
                int get = 1500;
                TargetScore2.text = get.ToString("0");
            }
            if (score >= 1500)
            {
                int get = 1750;
                TargetScore2.text = get.ToString("0");
            }
            if (score >= 1750)
            {
                int get = 2000;
                TargetScore2.text = get.ToString("0");
            }
        }

    }
    void setText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;
        if (GameActive)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }
        if (TargetScore)
        {
            if (GameActive && Waktu <= 0 && score > 250)
            {
                Debug.Log("YOU win");
                CanvasMenang.SetActive(true);
                GameActive = false;
            }
            if (GameActive && Waktu <= 0 && score < 250)
            {
                Debug.Log("Game Over");
                CanvasKalah.SetActive(true);
                GameActive = false;
            }
        }
        if (TargetScore1)
        {
            if (GameActive && Waktu <= 0 && score > 750)
            {
                Debug.Log("YOU win");
                CanvasMenang.SetActive(true);
                GameActive = false;
            }
            if (GameActive && Waktu <= 0 && score < 750)
            {
                Debug.Log("Game Over");
                CanvasKalah.SetActive(true);
                GameActive = false;
            }
        }
        if (TargetScore2)
        {
            if (GameActive && Waktu <= 0 && score > 1500)
            {
                Debug.Log("YOU win");
                CanvasMenang.SetActive(true);
                GameActive = false;
            }
            if (GameActive && Waktu <= 0 && score < 1500)
            {
                Debug.Log("Game Over");
                CanvasKalah.SetActive(true);
                GameActive = false;
            }
        }
        setText();
        OnTargetScore();

    }
    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
    }

}
