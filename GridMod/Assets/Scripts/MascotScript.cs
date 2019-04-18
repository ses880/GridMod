using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MascotScript : MonoBehaviour
{
    public int type = 0;
    
    public Sprite[] TextBubbles;

    
    // Start is called before the first frame update
    void Start()
    {
        type = 0;
        
        GetComponent<SpriteRenderer>().sprite = TextBubbles[type];
        


    }

    

    // Update is called once per frame
    void Update()
    {
        if (!TimerScript.Paused)
        {
            if (GridMaker.Instance.score >= 10)
            {
                type = 1;
            }

            if (GridMaker.Instance.score >= 20)
            {
                type = 2;
            }

            if (GridMaker.Instance.score >= 30)
            {
                type = 3;
            }

            if (GridMaker.Instance.score >= 40)
            {
                type = 4;
            }

            if (GridMaker.Instance.score >= 50)
            {
                type = 5;
            }

            if (GridMaker.Instance.score >= 60)
            {
                type = 6;
            }

            if (GridMaker.Instance.score >= 70)
            {
                type = 7;
            }

            if (GridMaker.Instance.score >= 80)
            {
                type = 8;
            }

            if (GridMaker.Instance.score >= 90)
            {
                type = 9;
            }

            if (GridMaker.Instance.score >= 100)
            {
                type = 10;
            }

            GetComponent<SpriteRenderer>().sprite = TextBubbles[type];
        }

        //public void setBubble()
        //{

        //}
    }
        
}
