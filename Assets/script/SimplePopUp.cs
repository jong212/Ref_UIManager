using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SimplePopUp : MonoBehaviour
{
    [SerializeField] Text Text_Msg;
    // ��� Ȯ��
    private void OnEnable()
    {
        StartCoroutine(CoCloseSelf());
    }
    private void OnDisable()
    {

    }

    public void SetUI(string msg)
    {
        Text_Msg.text = msg;
        CheckAndChangeColor(msg);
    }

    // ���Ȯ�� or ��ü ó�� �� private
    private void CheckAndChangeColor(string msg)
    {
        if (msg.Contains("���"))
        {
            Text_Msg.color = Color.red;
        }
    }
    // Start is called before the first frame update
    IEnumerator CoCloseSelf()
    {
        yield return new WaitForSeconds(1.5f);
        this.gameObject.SetActive(false);
        
    }
}
