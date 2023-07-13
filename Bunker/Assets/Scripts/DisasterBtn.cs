using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterBtn : MonoBehaviour
{
    public static GameManager gameManager;
    public Text DisasterTitle;
    public Text DisasterText;

    private void Awake()
    {
        DisasterBtnPressed();
    }

    public void DisasterBtnPressed()
    {
        KeyValuePair<string, string> Disaster = gameManager.GenerateDisaster();
        DisasterTitle.text = Disaster.Key;
        DisasterText.text = Disaster.Value;
    }
}
