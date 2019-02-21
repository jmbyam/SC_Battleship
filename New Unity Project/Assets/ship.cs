using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject model;
    public Renderer rend;
    public int size;

    ArrayList hits;

    public Ship(int size) {

        model = GameObject.CreatePrimitive(PrimitiveType.Plane);
        model.transform.localScale = new Vector3(size, 2, 1);
        this.size = size;
        rend = GetComponent<Renderer>();

        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.black);
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

