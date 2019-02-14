using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject model;

    public int size;
    ArrayList hits;

    public Ship(int size) {
        model = GameObject.CreatePrimitive(PrimitiveType.Cube);
        model.transform.localScale = new Vector3(size, 1, 1);
        this.size = size;
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

