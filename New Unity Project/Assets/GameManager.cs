using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject[,] gameField = new GameObject[6, 6];
    private Renderer[,] fieldRenderer = new Renderer[6, 6];
    private bool[,] fieldFlag = new bool[6, 6];
    private MovePlayer movePlayer;
    private int[] prevPos = new int[2];
    // Start is called before the first frame update
    void Start()
    {
        prevPos[0] = 0;
        prevPos[1] = 0;

        for (int x = 0; x < 6; x++)
        {
            for(int y = 0; y < x + 1; y++)
            {
                gameField[x, y] = GameObject.Find("Field" + x + y);
                fieldRenderer[x, y] = gameField[x, y].GetComponent<Renderer>();
                fieldRenderer[x, y].material.color = Color.red;
                fieldFlag[x, y] = false;
                movePlayer = GameObject.FindWithTag("Player").GetComponent<MovePlayer>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S))
        {
            int[] nowPos = new int[2];
            nowPos = movePlayer.getPlayerPos();

            if(prevPos[0] != nowPos[0] || prevPos[1] != nowPos[1])
            {
                prevPos = nowPos;
                ChangeColor(prevPos);
            }
        }
    }
    public void ChangeColor(int[] pos)
    {
        if (fieldFlag[pos[0], pos[1]])
        {
            fieldRenderer[pos[0], pos[1]].material.color = Color.red;
            fieldFlag[pos[0], pos[1]] = false;
        }
        else
        {
            fieldRenderer[pos[0], pos[1]].material.color = Color.blue;
            fieldFlag[pos[0], pos[1]] = true;
        }
    }
}
