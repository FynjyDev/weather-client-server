using UnityEngine.Networking;
using System.Collections;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    public DataManager DataManager;
    private string apiKey = "6e158cda558fb62251ab77306ba0c1b0";

    private void GetWeatherData(float _lon, float _lat)
    {
        StartCoroutine(OnGetWeatherData(BuildUrl(_lat, _lon)));
    }

    private IEnumerator OnGetWeatherData(string _url)
    {
        UnityWebRequest _webRequest = new UnityWebRequest(_url);
        _webRequest.downloadHandler = new DownloadHandlerBuffer();

        yield return _webRequest.SendWebRequest();

        if (_webRequest.result != UnityWebRequest.Result.Success) Debug.LogError(_webRequest.error);
        else SetWeatherData(_webRequest.downloadHandler.text);
    }

    private string BuildUrl(float _lon, float _lat)
    {
        return $"https://api.openweathermap.org/data/2.5/weather?lat={_lat}&lon={_lon}&appid={apiKey}&units=metric";
    }

    private void SetWeatherData(string _jsonData)
    {
        DataManager.WeatherData = JsonUtility.FromJson<WeatherData>(_jsonData);
    }
}


