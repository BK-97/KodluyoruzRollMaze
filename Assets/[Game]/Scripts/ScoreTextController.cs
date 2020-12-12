using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextController : MonoBehaviour
{
    private Text scoreText;
    public Text ScoreText
    {
        get
        {
            if(scoreText==null)
            {
                scoreText = GetComponent<Text>();
            }

            return scoreText;
        }
    }
    private void Start()
    {
        UpdateScoreText();
    }
    //When the object is activated
    private void OnEnable()
    {
        EventManager.onCoinPickUp.AddListener(UpdateScoreText);
    }
    //When the object is deactivated
    private void OnDisable()
    {
        EventManager.onCoinPickUp.RemoveListener(UpdateScoreText);
    }
    private void UpdateScoreText()
    {
        int point = FindObjectOfType<Player>().point;
        ScoreText.text = "Score = " + point;
    }
}
