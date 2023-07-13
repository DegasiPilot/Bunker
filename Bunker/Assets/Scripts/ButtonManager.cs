using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public static GameManager gameManager;
    Text buttonText;
    public string generatingParam;
    public static List<ButtonManager> AllButtons;


    private void Awake()
    {
        buttonText = GetComponentInChildren<Text>();
        try
        {
            AllButtons.Add(this);
        }
        catch
        {
            AllButtons = new List<ButtonManager>();
            AllButtons.Add(this);
        }
    }

    public void ButtonPressed()
    {
        buttonText.text = gameManager.GenerateParametr(generatingParam);
    }
}
