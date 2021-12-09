using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class test : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Sprite Sprite0;
    public InputField userField;//指向InputField的组件
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

    //public、void、不带参数
    //输入框以及按钮 UI
    public void Login()
    {
        string user = userField.text;
        Debug.Log("登录" + user);
    }

    //图片 UI，鼠标按下自动调用该方法
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("鼠标按下");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("鼠标抬起");
        //换图
        Image img = this.GetComponent<Image>();
        img.sprite = Sprite0;
    }
}
