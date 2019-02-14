using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customGrid : MonoBehaviour
{
    public float gridSize;
    public List<Ship> ships;
    
    private void Start()
    {
        Ship carrier = new Ship(5);
        Ship battleship = new Ship(4);
        Ship cruiser = new Ship(3);
        Ship submarine = new Ship(3);
        Ship destroyer = new Ship(2);
        ships = new List<Ship>();
        ships.Add(carrier);
        ships.Add(battleship);
        ships.Add(cruiser);
        ships.Add(submarine);
        ships.Add(destroyer);
    }
    void LateUpdate()
    {
        for (int i = 0; i < ships.Count; ++i)
        {
            GameObject target = ships[i].model;
            Vector3 truePos = target.transform.position;
            truePos.x = Mathf.Floor(target.transform.position.x / gridSize) * gridSize;
            truePos.y = Mathf.Floor(target.transform.position.y / gridSize) * gridSize;
            truePos.z = Mathf.Floor(target.transform.position.z / gridSize) * gridSize;

            if (truePos.x < 0)
            {
                truePos.x = 0;
            }
            else if (truePos.x > 10)
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

            target.transform.position = truePos;
        }

    }
}

