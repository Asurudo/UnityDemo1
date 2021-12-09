using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGame : MonoBehaviour
{
    public int score;
    public Text scoreText;
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Addscore()
    {
        score += 1;
        scoreText.text = "" + score;
    }
}
