using UnityEngine.Networking;
using System.Collections;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    private string apiKey = "6e158cda558fb62251ab77306ba0c1b0";

    public delegate void OnWeatherDataReady();
    public static OnWeatherDataReady onWeatherDataReady;

    public void GetWeatherData(string _lon, string _lat, DataManager _dataManager)
    {
        StartCoroutine(OnGetWeatherData(BuildUrl(_lat, _lon), _dataManager));
    }

    private IEnumerator OnGetWeatherData(string _url, DataManager _dataManager)
    {
        UnityWebRequest _webRequest = new UnityWebRequest(_url);
        _webRequest.downloadHandler = new DownloadHandlerBuffer();

        yield return _webRequest.SendWebRequest();

        if (_webRequest.result != UnityWebRequest.Result.Success) Debug.LogError(_webRequest.error);
        else
        {
            _dataManager.WeatherData = JsonUtility.FromJson<WeatherData>(_webRequest.downloadHandler.text);
            onWeatherDataReady?.Invoke();
        }
    }

    private string BuildUrl(string _lon, string _lat)
    {
        return $"https://api.openweathermap.org/data/2.5/weather?lat={_lat}&lon={_lon}&appid={apiKey}&units=metric";
    }
}


