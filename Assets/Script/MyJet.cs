using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyJet : MonoBehaviour
{
    public GameObject myPrefab;
    public float interval = 0.4f;
    private float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count >= interval)
        {
            count = 0;
            Fire();
        }

        int scW = Screen.width;
        Vector3 Screenps = Camera.main.WorldToScreenPoint(transform.position);
        //按键响应
        float step = 4.5f * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow) && Screenps.x > 1)
        {
            transform.Translate(-step, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && Screenps.x <= scW - 1)
        {
            transform.Translate(step, 0, 0);
        }
    }

    private void Fire()
    {
        //根据预制体创建一个游戏对象
        GameObject bullet = Instantiate(myPrefab);
        bullet.transform.position = transform.position + new Vector3(0, 1f, 0);
    }
}
