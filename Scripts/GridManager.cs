using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GridManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gridPrefab;
    public static int Row = 3;
    public static int Col = 3;
    private float space = 1.5f;
    private int[,] numbers = new int[Row, Col];

    public TextMeshPro textMeshPro;


    // Start is called before the first frame update
    void Start()
    {
        

        for (int i = 0; i < Row; i++) // for rows
        { 
            for (int j = 0; j < Col; j++) // for columns
            {
                GameObject grid = Instantiate(gridPrefab); 
                grid.transform.position = new Vector3(space * i, space * j, 0); // spawn cubes with spaces

                    //grid.transform.GetChild(0).GetComponent<TextMeshPro>().text = "O"; //display O on all cubes
                    
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
