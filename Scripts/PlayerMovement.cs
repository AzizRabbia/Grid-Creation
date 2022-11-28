using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
   
    private int playerRow = 0;
    private int playerColumn = 0;
    private string bird;
    List<string> birdsNames = new List<string>();

    public TextMeshProUGUI textpro;
    // Start is called before the first frame update
    void Start()
    {
         birdsNames.Add("Pigeon");   
         birdsNames.Add("Peacock");  
         birdsNames.Add("Ostrich");  
         birdsNames.Add("Turkey");   
         birdsNames.Add("Sparrow");  
         birdsNames.Add("Crow");     
         birdsNames.Add("Parrot");   
         birdsNames.Add("Cocktail"); 
         birdsNames.Add("Eagle");    
    }

    public void GetRandomBirdName()
    {
        bird = birdsNames[Random.Range(0, birdsNames.Count)];
        textpro.text = ("Bird name : " + bird);
    }

    // Update is called once per frame
    void Update()
    {
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
                GetRandomBirdName();
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
                GetRandomBirdName();
            }


        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerColumn += 1;
            if (playerColumn>2)
            {
                playerColumn -= 1;
            }
            else
            {
                transform.Translate(1.5f, 0, 0);
                GetRandomBirdName();
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
                GetRandomBirdName();
            }
        }
    }
}
