using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagerComponent : MonoBehaviour
{
    
    static public int points;
    public Text pointsText;

    void Start()
    {
        pointsText.text = "Score: " + points;
    }

    public void AddPoints(int numberOfPoints)
    {
        points += numberOfPoints;
        pointsText.text = "Score: " + points;
    }
    
    public void MainMenuView()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GameOverView()
    {
        SceneManager.LoadScene("GameOverScene");

    }
    public void Restart()
    {
        points = 0;
        SceneManager.LoadScene("SampleScene");
    }
}