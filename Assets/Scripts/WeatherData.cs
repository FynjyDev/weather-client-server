using System;
using System.Collections.Generic;

[Serializable]
public class WeatherData
{
    public List<Data> Data;
}

[Serializable]
public class Data
{
    public string name;
    public coord coord;
    public weather[] weather;
    public main main;
    public wind wind;
    public clouds clouds;
    public sys sys;
}

[Serializable]
public class coord
{
    public float lon;
    public float lat;
}

[Serializable]
public class weather
{
    public int id;
    public string main;
    public string description;
    public string icon;
}

[Serializable]
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

[Serializable]
public class wind
{
    public float speed;
    public float deg;
    public float gust;
}

[Serializable]
public class clouds
{
    public float all;
}

[Serializable]
public class sys
{
    public int type;
    public int id;
    public string country;
    public int sunrise;
    public int sunset;
}