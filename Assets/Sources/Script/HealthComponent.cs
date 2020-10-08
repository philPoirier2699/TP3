using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthComponent : MonoBehaviour
{

    static public int hp;
    public Text hpText;

    void Start()
    {
        hp = 100;
        hpText.text = "Health: " + hp;
    }

    public void AddPoints(int numberOfPoints)
    {
        hp += numberOfPoints;
        hpText.text = "Health: " + hp;
    }
    public void Restart()
    {
        hp = 0;
        SceneManager.LoadScene("SampleScene");
    }
}