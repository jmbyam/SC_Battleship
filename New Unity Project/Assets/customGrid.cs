using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customGrid : MonoBehaviour
{
    public GameObject target;
    public GameObject structure;
    Vector3 truePos;
    public float gridSize;

    void LateUpdate()
    {
        truePos.x = Mathf.Floor(target.transform.position.x / gridSize) * gridSize;
        truePos.y = Mathf.Floor(target.transform.position.y / gridSize) * gridSize;
        truePos.z = Mathf.Floor(target.transform.position.z / gridSize) * gridSize;

        if (truePos.x < 0)
        {
            truePos.x = 0;
        }
        else if ( truePos.x > 10 )
        {
            truePos.x = 10;
        }

        if (truePos.z < 0)
        {
            truePos.z = 0;
        }
        else if (truePos.z > 10)
        {
            truePos.z = 10;
        }

        structure.transform.position = truePos;
    }
}

