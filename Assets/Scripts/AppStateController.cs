using UnityEngine;

public class AppStateController : MonoBehaviour
{
    public DataManager DataManager;
    public UserInterfaceManager UIManager;

    private void Awake()
    {
        GetData();
    }

    private void GetData()
    {
        DataManager.OnGetData();
    }

    public void UpdateData()
    {
        string _temperature = DataManager.WeatherData.main.temp.ToString();
        string _feelsTemperature = DataManager.WeatherData.main.feels_like.ToString();

        string _wholeFeelsTemperature = _feelsTemperature.Substring(0, _temperature.IndexOf(",") - 1);
        string _wholeTemperature = _temperature.Substring(0, _temperature.IndexOf(","));

        UIManager.ShowData(_wholeTemperature, _wholeFeelsTemperature, DataManager.DateData.dayName, DataManager.DateData.dayNumber);
    }
}
