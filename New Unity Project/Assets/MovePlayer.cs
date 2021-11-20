using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private int playerXPos, playerZPos;
    // Start is called before the first frame update
    void Start()
    {
        playerXPos = 0;
        playerZPos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if(playerXPos < 5)
            {
                transform.position += new Vector3(-0.7f, -1f, -0.7f);
                playerXPos++;
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if(playerXPos < 5)
            {
                transform.position += new Vector3(0.7f, -1f, -0.7f);
                playerXPos++;
                playerZPos++;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if(playerXPos > 0 && playerZPos > 0)
            {
                transform.position += new Vector3(-0.7f, 1f, 0.7f);
                playerXPos--;
                playerZPos--;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if(playerXPos > 0 && playerZPos != playerXPos)
            {
                transform.position += new Vector3(0.7f, 1f, 0.7f);
                playerXPos--;
            }
            
        }
    }

    public int[] getPlayerPos()
    {
        int[] tmp = new int[2];
        tmp[0] = playerXPos;
        tmp[1] = playerZPos;
        return tmp;
    }
}
