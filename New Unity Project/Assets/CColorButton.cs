
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CColorButton : MonoBehaviour
{
    public Button button;

    private bool buttonFlag = false;

    private void Start()
    {
        ColorBlock temp = button.colors;

        temp.normalColor = temp.normalColor;
        temp.disabledColor = temp.normalColor;
        temp.highlightedColor = temp.normalColor;
        temp.pressedColor = temp.normalColor;
        button.colors = temp;
    }

    public void buttonPressed()
    {
        ColorBlock temp = button.colors;

        if ( ! buttonFlag )
        {
            temp.normalColor = Color.white;
            temp.highlightedColor = Color.white;
            button.colors = temp;
            buttonFlag = true;
        }
        else
        {
            temp.normalColor = Color.red;
            temp.highlightedColor = Color.red;
            button.colors = temp;
            buttonFlag = false;
        }
    }
}
