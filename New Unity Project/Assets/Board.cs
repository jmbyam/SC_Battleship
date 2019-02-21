using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject board;
    public Color boardColor;

    public Board() {
        board = GameObject.CreatePrimitive(PrimitiveType.Plane);
        board.transform.localScale = new Vector3(10, 1, 10);
        this.boardColor = Color.blue; 
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
