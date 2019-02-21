using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject board;
    public Renderer rend;

    public Board() {

        board = GameObject.CreatePrimitive(PrimitiveType.Plane);
        board.transform.localScale = new Vector3(5, 1, 5);
        rend = GetComponent<Renderer>();

        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.blue);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
