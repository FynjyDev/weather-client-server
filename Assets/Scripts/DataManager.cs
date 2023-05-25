using System.Collections.Generic;
using UnityEngine;
using System;

public class DataManager : MonoBehaviour
{
    public List<CityData> CitiesData;
    public WeatherData WeatherData;

}
[Serializable]
public class CityData
{
    public string CityName;
    public float Lon;
    public float Lat;
}
