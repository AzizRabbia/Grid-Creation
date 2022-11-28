using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{

    private int playerRow = 0;
    private int playerColumn = 0;
    public GameObject Text;
   // public GameObject cube;
   // List<string> gamealphabets = new List<string>();

   //public TextMeshProUGUI textpro;
    public TextMeshPro textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
       
      
    }

  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Text.SetActive(true);
            Debug.Log("O Pressed");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRow += 1;
            if (playerRow > 2)
            {
                playerRow -= 1;
              
            }
            else
            {
                transform.Translate(0, 1.5f, 0);
               
            }

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))

        {
            playerRow -= 1;
            if (playerRow < 0)
            {
                playerRow += 1;
            }
            else
            {
                transform.Translate(0, -1.5f, 0);
             
            }


        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerColumn += 1;
            if (playerColumn > 2)
            {
                playerColumn -= 1;
            }
            else
            {
                transform.Translate(1.5f, 0, 0);
              
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerColumn -= 1;
            if (playerColumn < 0)
            {
                playerColumn += 1;
            }
            else
            {
                transform.Translate(-1.5f, 0, 0);
                
            }
        }
       

        print(playerRow+ "," + playerColumn);
      
    }
}
