using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
     
    //[SerializeField] SimplePopUp Popup_SimplePopup; �� ���� �ڵ� ���� (�ٸ� �� ����̾�)
    
    public void OnClick_PopupSimpleMsg()
    {
        UIManager.Instance.OpenSimplePopup("���� �˾� ��� ��");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
