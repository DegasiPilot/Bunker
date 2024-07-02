using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public int MinAge => _minAge;
    [SerializeField] private int _minAge;
    public int MaxAge => _maxAge;
    [SerializeField] private int _maxAge;

    [SerializeField] private InputField _minAgeInputField;
    [SerializeField] private InputField _maxAgeInputField;

    private void Awake()
    {
        _minAgeInputField.text = MinAge.ToString();
        _maxAgeInputField.text = MaxAge.ToString();

        _minAgeInputField.onEndEdit.AddListener(UpdateMinAge);
        _maxAgeInputField.onEndEdit.AddListener(UpdateMaxAge);
    }

    private void UpdateMinAge(string minAge)
    {
        int newMinAge;
        if(!int.TryParse(minAge, out newMinAge) || newMinAge < 0 || newMinAge > _maxAge)
        {
            _minAgeInputField.SetTextWithoutNotify(_minAge.ToString());
        }
        else
        {
            _minAge = newMinAge;
        }
    }
    
    private void UpdateMaxAge(string maxAge)
    {
        int newMaxAge;
        if (!int.TryParse(maxAge, out newMaxAge) || newMaxAge < 0 || newMaxAge < _minAge)
        {
            _maxAgeInputField.SetTextWithoutNotify(_maxAge.ToString());
        }
        else
        {
            _maxAge = newMaxAge;
        }
    }
}