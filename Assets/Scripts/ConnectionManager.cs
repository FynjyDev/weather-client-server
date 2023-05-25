using UnityEngine.Networking;
using System.Collections;
using UnityEngine;

public class ConnectionManager : MonoBehaviour
{
    public DataManager DataManager;
    private string apiKey = "6e158cda558fb62251ab77306ba0c1b0";

    private void Awake()
    {
        for (int i = 0; i < DataManager.CitiesData.Count; i++)
            StartCoroutine(GetWeatherData(BuildUrl(DataManager.CitiesData[i].Lat, DataManager.CitiesData[i].Lon)));
    }

    private IEnumerator GetWeatherData(string _url)
    {
        UnityWebRequest _webRequest = new UnityWebRequest(_url);
        _webRequest.downloadHandler = new DownloadHandlerBuffer();

        yield return _webRequest.SendWebRequest();

        if (_webRequest.result != UnityWebRequest.Result.Success) Debug.LogError(_webRequest.error);
        else SetDataWeather(_webRequest.downloadHandler.text);
    }

    private string BuildUrl(float _lon, float _lat)
    {
        return $"https://api.openweathermap.org/data/2.5/weather?lat={_lat}&lon={_lon}&appid={apiKey}&units=metric";
    }

    private void SetDataWeather(string _jsonData)
    {
        DataManager.WeatherData.Data.Add(JsonUtility.FromJson<Data>(_jsonData));
    }
}


