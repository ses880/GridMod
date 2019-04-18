using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PondManager : MonoBehaviour
{
    public static GameObject[,] lilyPad;

    public GameObject lilyPadPrefab;
    
    public GameObject PondMaker;

    public const int Width2 = 4;
    public const int Height2 = 4;

    float xOffset = Width2 / 2f - 0.5f;
    float yOffset = Height2 / 2f - 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        lilyPad = new GameObject[Width2, Height2];
        PondMaker = new GameObject();
        PondMaker.transform.position = new Vector3(0, 0, 0);

        //Instance = this;

        //source = GetComponent<AudioSource>();


        for (int x = 0; x < Width2; x++)
        {
            for (int y = 0; y < Height2; y++)
            {
                GameObject newPad = Instantiate(lilyPadPrefab);
                newPad.transform.parent = PondMaker.transform;
                newPad.transform.localPosition = new Vector2(Width2 - x - xOffset, Height2 - y - yOffset);
                lilyPad[x, y] = newPad;
                //TileScript tileScript = newTile.GetComponent<TileScript>();
                //tileScript.SetSprite(Random.Range(0, tileScript.Sprites.Length));


            }
            

            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
