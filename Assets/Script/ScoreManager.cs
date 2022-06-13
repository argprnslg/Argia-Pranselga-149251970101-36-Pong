using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int RightScore;
    public int LeftScore;

    public int MaxScore;

    public BallController ball;

    public void AddRightScore(int increment)
    {
        RightScore += increment;
        ball.ResetBall();

        if (RightScore >= MaxScore)
        {
            GameOver();
        }
    }

    public void AddLeftScore(int increment)
    {
        LeftScore += increment;
        ball.ResetBall();

        if (LeftScore >= MaxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu 1");
    }
}
