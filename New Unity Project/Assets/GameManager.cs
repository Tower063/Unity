using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject[,] gameField = new GameObject[6,6];
    private int[,] playerPos;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 6; x++)
        {
            for(int y = 0; y < x + 1; y++)
            {
                gameField[x, y] = GameObject.Find("Field" + x + y);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
