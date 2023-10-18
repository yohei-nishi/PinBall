using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;

    //���݂̃X�R�A
    private int scoreCount = 0;

    //���Z����X�R�A
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

    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    {
        //Tag�ɂ�鎯��
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

        //�X�R�A�����Z
        this.scoreCount += this.scoreUp;
    }
}
