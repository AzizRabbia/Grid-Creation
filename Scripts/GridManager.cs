using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gridPrefab;
    public static int Row = 3;
    public static int Col = 3;
    private float space = 1.5f;
    private int[,] numbers = new int[Row, Col];
   
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Row; i++)
        {
            for (int j = 0; j < Col; j++)
            {
                GameObject grid = Instantiate(gridPrefab);
                grid.transform.position = new Vector3(space * i, space * j, 0f);
            }

        }

        


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
