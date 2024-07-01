using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public int playerHitPoint = 10 ;
    public Text hitPointText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        scoreText.text = "Score ：" + score;
        hitPointText.text = "HP : " + playerHitPoint;
    }
}
