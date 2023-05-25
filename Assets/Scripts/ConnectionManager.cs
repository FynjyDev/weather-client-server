using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class ConnectionManager : MonoBehaviour
{
    public WeatherData weatherData;

    private string url = "https://api.openweathermap.org/data/2.5/weather?lat=55.751244&lon=37.618423&appid=6e158cda558fb62251ab77306ba0c1b0&units=metric";

    private void Awake()
    {
        StartCoroutine(GetWeatherData());
    }

    private IEnumerator GetWeatherData()
    {
        UnityWebRequest www = new UnityWebRequest(url);
        www.downloadHandler = new DownloadHandlerBuffer();

        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success) Debug.LogError(www.error);
        else GetWeather(www.downloadHandler.text);
    }

    private void GetWeather(string _jsonData)
    {
        weatherData = JsonUtility.FromJson<WeatherData>(_jsonData);
    }
}
