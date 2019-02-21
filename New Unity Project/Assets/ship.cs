using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject model;
    public Color shipColor;
    public int size;

    ArrayList hits;

    public Ship(int size) {
        model = GameObject.CreatePrimitive(PrimitiveType.Cube);
        model.transform.localScale = new Vector3(size, 3, 1);
        this.size = size;
        this.shipColor = Color.black;
        hits = new ArrayList();

        for (int i = 0; i < size; ++i)
        {
            hits.Add(false);
        }
    }

    void LateUpdate()
    {

    }
}

