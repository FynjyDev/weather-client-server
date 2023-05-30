using UnityEngine.Networking;
using System.Collections;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
	public delegate void OnLocationDataReady();
	public static OnLocationDataReady onLocationDataReady;

	public void GetLocationData(DataManager _dataManager)
	{
		StartCoroutine(OnGetLocationData(_dataManager));
	}

	private IEnumerator OnGetLocationData(DataManager _dataManager)
	{
		UnityWebRequest _webRequest = UnityWebRequest.Get("https://ipinfo.io/json?token=2fed08aa6b1760");

		yield return _webRequest.SendWebRequest();

		if (_webRequest.result != UnityWebRequest.Result.Success) Debug.LogError(_webRequest.error);
		else
		{
			_dataManager.LocationData = JsonUtility.FromJson<LocationData>(_webRequest.downloadHandler.text);
			onLocationDataReady?.Invoke();
		}
	}
}
