using TMPro;
using UnityEngine;

public class UserInterfaceManager : MonoBehaviour
{
    public TextMeshProUGUI TemperatureText;
    public TextMeshProUGUI FeelsLikeTemperatureText;
    public TextMeshProUGUI DateText;

    public void ShowData(string _temperature, string _feelsLike, string _dayName, string _dayNumber)
    {
        TemperatureText.text = _temperature;
        FeelsLikeTemperatureText.text = $"Feels like {_feelsLike}";

        DateText.text = $"{_dayName} {_dayNumber}";
    }
}
