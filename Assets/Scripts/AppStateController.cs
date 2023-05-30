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
        string _wholeTemperature = _temperature.Substring(0, _temperature.IndexOf(","));

        UIManager.ShowData(_wholeTemperature);
    }
}
