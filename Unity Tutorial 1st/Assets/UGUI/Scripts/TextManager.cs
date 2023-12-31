using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ButtonText
{
    public string buttonName;
}

public class TextManager : MonoBehaviour
{
    public Text [ ] buttonTexts;
    public ButtonText [ ] buttonText = new ButtonText[4];

    void Start()
    {
        for(int i = 0; i < buttonTexts.Length; i++)
        {
            buttonTexts[i].text = buttonText[i].buttonName;
        }
    }
}