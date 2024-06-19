using System.Collections.Generic;
using UnityEngine;

public enum UIType
{
    SimplePopup,
    MainUI,
}
public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] SimplePopUp _simplePopup;
 private Dictionary<UIType,GameObject> _opendUIDic = new Dictionary<UIType, GameObject>();
    private void OpenUI(UIType uiType,GameObject uiObject)
    {
        if(_opendUIDic.ContainsKey(uiType) == false)
        {
            uiObject.SetActive(true);
            _opendUIDic.Add(uiType,uiObject);
        } else {
            Debug.Log("test");
        }
    }
    private void Awake()
    {
        Instance = this;
    }
    //Extension이 무조건 MVVM에서만 사용하는건 아님 
    public void OpenSimplePopup(string msg)
    {
        if(_simplePopup != null)
        {
            OpenUI(UIType.SimplePopup, _simplePopup.gameObject);

            //_simplePopup.gameobject.SetActive(true); -> OpenUI로 역할 이전
            _simplePopup.SetUI(msg);
        }
    }

}
