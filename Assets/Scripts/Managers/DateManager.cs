using System;
using UnityEngine;

public class DateManager : MonoBehaviour
{
	public void GetDateData(DataManager _dataManager)
	{
		string _dayNumber = DateTime.Now.Day.ToString();
		string _dayName = DateTime.Now.DayOfWeek.ToString(); //DateTime.Now.ToString("dddd") localization

		_dataManager.DateData.dayName = _dayName;
		_dataManager.DateData.dayNumber = _dayNumber;
	}
}
