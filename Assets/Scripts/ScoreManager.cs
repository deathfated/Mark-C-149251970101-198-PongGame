using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    public int maxScore;
    public BoolController bol;
 
        public void AddRightScore(int increment)
        {
            rightScore += increment;
            bol.ResetBall();
            if (rightScore >= maxScore)
            {
                GameOver();
            }
        }

        public void AddLeftScore(int increment)
        {
            leftScore += increment;
            bol.ResetBall();
            if (leftScore >= maxScore)
            {
                GameOver();
            }
        }

        public void GameOver()
        {
            SceneManager.LoadScene("MainMenu");
        }
}
