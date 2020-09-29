using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int score = 0;
    public int ARNLosts = 0;
    public Text proteinCount;
    public Text ARNLostCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void addProtein()
    {
        score++;
    }

    public void addARNLost()
    {
        ARNLosts++;
    }

    // Update is called once per frame
    void Update()
    {
        ARNLostCount.text = "ARN perdidos: " + ARNLosts;
        proteinCount.text = "Proteinas creadas: " + score;
    }
}
