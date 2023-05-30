using UnityEngine;

public class DataManager : MonoBehaviour
{
    public AppStateController StateController;

    [Header("Location")]
    public LocationManager LocationManager;
    public LocationData LocationData;

    [Header("Date")]
    public DateManager DateManager;
    public DateData DateData;

    [Header("Weather")]
    public WeatherManager WeatherManager;
    public WeatherData WeatherData;

    private void OnEnable()
    {
        LocationManager.onLocationDataReady += GetWeatherData;
        WeatherManager.onWeatherDataReady += OnAllDataReady;
    }

    public void OnGetData()
    {
        LocationManager.GetLocationData(this);
        DateManager.GetDateData(this);
    }

    private void GetWeatherData()
    {
        string _lat = LocationData.loc.Substring(LocationData.loc.IndexOf(",") + 1); 
        string _lon = LocationData.loc.Substring(0, LocationData.loc.IndexOf(","));

        WeatherManager.GetWeatherData(_lon, _lat, this);
    }

    private void OnAllDataReady()
    {
        StateController.UpdateData();
    }

    private void OnDisable()
    {
        LocationManager.onLocationDataReady += GetWeatherData;
        WeatherManager.onWeatherDataReady -= OnAllDataReady;
    }
}
