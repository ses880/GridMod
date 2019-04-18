using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public Text pauseText;
    public float Timer;


    public static bool Paused = false;


    // Start is called before the first frame update
    void Start()
    {
        Timer = 120f;
        
    }
    

    // Update is called once per frame
    void Update()
    {
        


        Timer -= Time.deltaTime;

        

        if (Timer < 0)
        {
            pauseGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Paused = !Paused;
            unpauseGame();
            
        }

        timerText.text = "Time Left:" + Timer;


    }

    void timerOn()
    {


        
        if (!Paused)
        {
            Timer -= Time.deltaTime;

        }
        else if (Paused)
        {
            Timer = Timer;
        }
        
    }
    public void pauseGame()
    {
        Paused = true;
        Time.timeScale = 0;
        pauseText.text = "Game Over! Press Esc to Replay.";
        //PlayerScript.movePlayer.(int x, int y).Stop;

    }

    public void unpauseGame()
    {
        Paused = false;
        Time.timeScale = 1;
        Timer = 120f;
        pauseText.text = "";
        GridMaker.Instance.score = 0;


    }
}
