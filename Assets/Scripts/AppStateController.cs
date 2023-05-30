using UnityEngine;

public class AppStateController : MonoBehaviour
{
    public DataManager DataManager;
    public UserInterfaceManager UIManager;

    private void Awake()
    {
        GetData();
    }

    private void GetData()
    {
        DataManager.OnGetData();
    }

    public void UpdateData()
    {
        UIManager.ShowData();
    }
}
