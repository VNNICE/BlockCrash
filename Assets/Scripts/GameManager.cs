using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField] int ballCount = 3;
    [SerializeField] GameObject gameOverText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI lifeText;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI resultScore;
    [SerializeField] TextMeshProUGUI resultTime;
    [SerializeField] TextMeshProUGUI resultLife;
    [SerializeField] TextMeshProUGUI resultTotalScore;
    [SerializeField] TextMeshProUGUI highScoreUI;
    private static int highScore = 0;

    [SerializeField] GameObject GameClear;
    [SerializeField] GameObject resultRoot;

    private int score = 0;
    [SerializeField] private float leftTime = 30;
    private bool inGame = true;

    private int brokenObjectCount;

    private void SetScoreText()
    {
        if (highScore < score)
        {
            scoreText.text = "Score: " + score;
            highScoreUI.text = "HighScore: " + highScore + "  NEW!";
        }
        else
        {
            scoreText.text = "Score: " + score;
            highScoreUI.text = "HighScore: " + highScore;
        }
    }

    public void GameClearOn()
    {
        GameClear.SetActive(true);
        showResult();
        GetComponent<TitleManager>().ST1_CLR = true;
        GetComponent<TitleManager>().ST2_CLR = true;
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        showResult();
    }

    public void AddScore(int point)
    {
        score += point;
        SetScoreText();
    }
    private void SetLifeText()
    {
        lifeText.text = "Life: " + ballCount;
    }

    private void showResult()
    {
        resultRoot.SetActive(true);
        resultScore.text = "Score: " + score;
        resultTime.text = "Time: " + Mathf.RoundToInt(leftTime) + " Å~ 100 = " + Mathf.RoundToInt(leftTime) * 100;
        resultLife.text = "Life: " + ballCount + " Å~ 500 = " + ballCount * 500;
        int NoTotalScore = score + ballCount * 500 + Mathf.RoundToInt(leftTime) * 100;
        resultTotalScore.text = "TotalScore: " + NoTotalScore;
        if (highScore < NoTotalScore)
        {
            highScore = NoTotalScore;
        }
    }

    public void OnTapRestar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Start()
    {
        GameClear.SetActive(false);
        gameOverText.SetActive(false);
        SetScoreText();
        brokenObjectCount = FindObjectsOfType<Broken>().Length;
        resultRoot.SetActive(false);
    }

    private void Update()
    {
        SetLifeText();
        if (inGame == true)
        {
            leftTime -= Time.deltaTime;
            timeText.text = "Time: " + Mathf.RoundToInt(leftTime);
            if (leftTime <= 0)
            {
                inGame = false;
                timeText.text = "Time: 0";
                GameOver();
            }
        }
    }

    public void OnKillBall()
    {
        if (ballCount > 0)
        {
            ballCount--;
            GameObject newBall = Instantiate(ballPrefab);
            newBall.name = ballPrefab.name;
        }
        else if (inGame == true)
        {
            inGame = false;
            GameOver();
        }
    }
    public void OnBroken()
    {
        brokenObjectCount--;
        if (brokenObjectCount <= 0)
        {
            inGame = false;
            GameClearOn();
        }
    }
}