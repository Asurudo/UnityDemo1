using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{
    public GameObject monsterprefab;

    //多张图片
    public Sprite[] imgs;
    // Start is called before the first frame update
    void Start()
    {
        //定时调用方法/多长时间以后执行第一次/执行间隔
        InvokeRepeating("CreateMonster", 0.1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateMonster()
    {
        float x = Random.Range(-3, 3);
        float y = 5;
        GameObject monster = Instantiate(monsterprefab);
        monster.transform.position = new Vector3(x, y, 0);

        //多张图片
        int index = Random.Range(0, imgs.Length);
        SpriteRenderer renderer = monster.GetComponent<SpriteRenderer>();
        renderer.sprite = this.imgs[index];

        //设置头像大小，对原来图像进行缩放
        Sprite sprite = this.imgs[index];
        float scale = 0.5f;
        monster.transform.localScale = new Vector3(scale, scale, scale);
    }
}
