using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SettingsManager _settingsManager;

    private void Awake()
    {
        ButtonManager.gameManager = this;
        DisasterBtn.gameManager = this;
        DataManager.shalun();
    }

    private void Start()
    {
        GenerateAll();
    }

    public string GenerateParametr(string parametr)
    {
        if (parametr == "Age")
        {
            return Random.Range(_settingsManager.MinAge, _settingsManager.MaxAge + 1).ToString();
        }

        List<string> parametrList = DataManager.ListsDictionary[parametr];
        return parametrList[Random.Range(0, parametrList.Count)];
    }

    public void GenerateAll()
    {
        foreach (ButtonManager btn in ButtonManager.AllButtons)
        {
            btn.ButtonPressed();
        }
    }

    public KeyValuePair<string, string> GenerateDisaster()
    {
        string DisasterKey = DataManager.DisastersKeys[Random.Range(0, DataManager.DisastersKeys.Count)];
        return new KeyValuePair<string, string>(DisasterKey, DataManager.Disaster[DisasterKey]);
    }
}