using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class test : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Sprite Sprite0;
    public InputField userField;//ָ��InputField�����
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int value)
    {
        
    }

    //public��void����������
    //������Լ���ť UI
    public void Login()
    {
        string user = userField.text;
        Debug.Log("��¼" + user);
    }

    //ͼƬ UI����갴���Զ����ø÷���
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("��갴��");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("���̧��");
        //��ͼ
        Image img = this.GetComponent<Image>();
        img.sprite = Sprite0;
    }
}
