using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonWeatherData
{

}

[System.Serializable]
public class coord
{
    public float lon;
    public float lat;
}

[System.Serializable]
public class weather
{
    public int id;
    public string main;
    public string description;
    public string icon;
}

[System.Serializable]
public class main
{
    public float temp;
    public float feels_like;
    public float temp_min;
    public float temp_max;
    public int pressure;
    public int humidity;
    public float sea_level;
    public float grnd_level;
}

[System.Serializable]
public class wind
{
    public float speed;
    public float deg;
    public float gust;
}


[System.Serializable]
public class clouds
{
    public float all;
}

[System.Serializable]
public class sys
{
    public int type;
    public int id;
    public string country;
    public int sunrise;
    public int sunset;
}

[System.Serializable]
public class WeatherData
{
    public coord coord;
    public weather[] weather;
    public main main;
    public int visibility;
    public wind wind;
    public clouds clouds;
    public int dt;
    public sys sys;
    public int timezone;
    public int id;
    public string name;
    public int cod;
}



