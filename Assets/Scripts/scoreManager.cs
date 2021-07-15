using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int currentBerry = 0;
    public int currentScore = 20;
    public int currentBirds = 0;
    public Scene currentScene;
    public int whichScene;
    public void addBerry(int score){
            currentBerry += score;
    }

    public void changeScore(int score){
        currentScore -= score;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        if(currentScene.name == "scene_one"){
            whichScene = 1;
        }
        if(currentScene.name == "scene_two"){
            whichScene = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(whichScene == 1){
            scoreText.text = currentBerry.ToString();
        }
        if(whichScene == 2){
            scoreText.text = currentScore.ToString();
        }
    }
}
