using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onPlay()
    {
        SceneManager.LoadScene("Level");
    }
    public void onSet()
    {
        SceneManager.LoadScene("Setting");
    }
    public void onPlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void onMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void onLose()
    {
        SceneManager.LoadScene("Lose");
    }
}
