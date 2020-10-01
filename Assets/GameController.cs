using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int score = 0;
    public int ARNLosts = 0;
    private int basalEnergy = 10; 
    public Text proteinCount;
    public Text ARNLostCount;
    public Text basalEnergyText;
    public GameObject winScreen;
    public GameObject gameOver;
    public static bool gameIsPaused;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void addProtein()
    {
        score++;
    }

    public void addARNLost()
    {
        ARNLosts++;
        basalEnergy--;
    }


    // Update is called once per frame
    void Update()
    {
        if(basalEnergy <= 0)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
        if(score >= 15)
        {
            Time.timeScale = 0;
            winScreen.SetActive(true);
        }
        ARNLostCount.text = "ARN perdidos: " + ARNLosts;
        proteinCount.text = "Proteinas creadas: " + score;
        if(basalEnergy <= 5)
        {
            basalEnergyText.color = Color.red;
        }
        basalEnergyText.text = "Recursos basales disponibles: \n" + basalEnergy;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Game");

    }
}
