using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogScript : MonoBehaviour
{
    public int type2 = 0;
    public Sprite[] Frogs;

    // Start is called before the first frame update
    void Start()
    {
        type2 = 0;

        GetComponent<SpriteRenderer>().sprite = Frogs[type2];

    }

    // Update is called once per frame
    void Update()
    {
        if (!TimerScript.Paused)
        {
            if (GridMaker.Instance.score >= 10)
            {
                type2 = 1;
            }

            if (GridMaker.Instance.score >= 20)
            {
                type2 = 2;
            }

            

            if (GridMaker.Instance.score >= 40)
            {
                type2 = 3;
            }

            

            if (GridMaker.Instance.score >= 60)
            {
                type2 = 3;
            }

            if (GridMaker.Instance.score >= 100)
            {
                type2 = 4;
            }

            

            

            

            if (GridMaker.Instance.score >= 100)
            {
                type2 = 6;
            }

            GetComponent<SpriteRenderer>().sprite = Frogs[type2];
        }

    }
}
