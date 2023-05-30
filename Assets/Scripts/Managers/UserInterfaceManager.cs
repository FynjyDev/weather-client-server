using TMPro;
using UnityEngine;

public class UserInterfaceManager : MonoBehaviour
{
    public TextMeshProUGUI TemperatureText;

    public void ShowData(string _temperature)
    {
        TemperatureText.text = _temperature;
    }
}
