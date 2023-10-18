using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //スコアを表示するテキスト
    private GameObject scoreText;

    //現在のスコア
    private int scoreCount = 0;

    //加算するスコア
    private int scoreUp;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        string score = scoreCount.ToString();

        this.scoreText.GetComponent<Text>().text =  score;
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        //Tagによる識別
        if (other.gameObject.tag == "SmallStarTag")
        {
            scoreUp = 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        { 
            scoreUp= 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            scoreUp = 50;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            scoreUp = 100;
        }

        //スコアを加算
        this.scoreCount += this.scoreUp;
    }
}
