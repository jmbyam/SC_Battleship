using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    public List<CColorButton> buttons;
    public int gridSize = 10;


    public Board() {

        for (char letter = 'A'; letter < gridSize; ++letter)
        {
            for (int num = 1; num < gridSize; ++num)
            {
                string str = letter + num.ToString();
                buttons.Add(GameObject.Find(str).GetComponent<CColorButton>());
                Debug.Log(str);
            }
        }
    }

    private void Start()
    {
        for (char letter = 'A'; letter < gridSize; ++letter)
        {
            for (int num = 1; num < gridSize; ++num)
            {
                string str = letter + num.ToString();
                buttons.Add(GameObject.Find(str).GetComponent<CColorButton>());
                Debug.Log(str);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        ColorBlock temp = buttons[0].button.colors;

        temp.normalColor = Color.white;
        temp.disabledColor = temp.normalColor;
        temp.highlightedColor = temp.normalColor;
        temp.pressedColor = temp.normalColor;
        buttons[0].button.colors = temp;
    }
}
