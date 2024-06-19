using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
     
    //[SerializeField] SimplePopUp Popup_SimplePopup; 안 좋은 코드 예시 (다른 걸 들고이씀)
    
    public void OnClick_PopupSimpleMsg()
    {
        UIManager.Instance.OpenSimplePopup("심플 팝업 출력 됨");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
