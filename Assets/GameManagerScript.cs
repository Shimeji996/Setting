using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    int[] map;

    void PrintArray()
    {
        string debugText = "";
        for(int i = 0; i < map.Length; i++) 
        {
            debugText += map[i].ToString() + ",";
        }
        Debug.Log(debugText);
    }

    // Start is called before the first frame update
    void Start()
    {
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0, };
        PrintArray();
    }

    // Update is called once per frame
    void Update()
    {
        int playerIndex = -1;

        for (int i = 0; i < map.Length; ++i)
        {
            if (map[i] == 1)
            {
                playerIndex = i;
                break;
            }
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (playerIndex < map.Length - 1)
            {
                map[playerIndex + 1] = 1;
                map[playerIndex] = 0;

                string debugText = "";
                for (int i = 0; i < map.Length; i++)
                {
                    debugText += map[i].ToString() + ",";
                }
                Debug.Log(debugText);

            }
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (playerIndex > map.Length + 1)
            {
                map[playerIndex - 1] = 1;
                map[playerIndex] = 0;

                string debugText = "";
                for (int i = 0; i < map.Length; i++)
                {
                    debugText += map[i].ToString() + ",";
                }
                Debug.Log(debugText);

            }
        }

    }
}
