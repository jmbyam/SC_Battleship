
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CColorButton : MonoBehaviour
{
    public Button button;

    private bool buttonFlag = false;
    private int index = 1;

    public void buttonPressed()
    {
    
        button.colors = UnityEngine.UI.ColorBlock.defaultColorBlock;
        buttonFlag = false;

    }
}
