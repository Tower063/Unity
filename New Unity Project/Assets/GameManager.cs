using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject[,] gameField = new GameObject[6,6];
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 6; x++)
        {
            for(int y = 0; y < x + 1; y++)
            {
                gameField[x, y] = GameObject.Find("Field" + x + y);
                gameField[x, y].GetComponent<Material>().color = Color.red;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public bool ChangeColor(int X, int Z)
    {
        gameField[X, Z].GetComponent<Material>().color = Color.red;
        return true;
    }
}
