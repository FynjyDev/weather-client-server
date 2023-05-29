using UnityEngine.Networking;
using System.Collections;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
	public DataManager DataManager;

	private void Start()
	{
		StartCoroutine(OnGetLocationData());
	}

	private IEnumerator OnGetLocationData()
	{
		UnityWebRequest _webRequest = UnityWebRequest.Get("https://ipinfo.io/json?token=2fed08aa6b1760");

		yield return _webRequest.SendWebRequest();

		if (_webRequest.result != UnityWebRequest.Result.Success) Debug.LogError(_webRequest.error);
		else SetLocationData(_webRequest.downloadHandler.text);
	}

	private void SetLocationData(string _jsonData)
	{
		DataManager.LocationData = JsonUtility.FromJson<LocationData>(_jsonData);
	}
}
