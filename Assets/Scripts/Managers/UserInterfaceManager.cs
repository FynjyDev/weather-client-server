using TMPro;
using UnityEngine;

public class UserInterfaceManager : MonoBehaviour
{
    public TextMeshProUGUI TemperatureText;
    public TextMeshProUGUI DateText;

    public void ShowData(string _temperature, string _dayName, string _dayNumber)
    {
        TemperatureText.text = _temperature;

        DateText.text = $"{_dayName} {_dayNumber}";
    }
}
