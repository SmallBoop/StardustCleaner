using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public int score = 0;
    public int maxScore;
    [SerializeField] private GameObject CutScene;



    void Start()
    {
        score = 0;
    }

    public void AddScore()
    {
        score += 1;
        ScoreText.text = "Score: " + score ;
    }

    void Update()
    {
        //UpdateScore();

        if (score == maxScore)
        {
            CutScene.GetComponent<StartCutScene>().FinalCutScene();
        }
    }
}
