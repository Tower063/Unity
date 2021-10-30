using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.position += new Vector3(-0.7f, -1f, -0.7f);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.position += new Vector3(0.7f, -1f, -0.7f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-0.7f, 1f, 0.7f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0.7f, 1f, 0.7f);
        }
    }
}
