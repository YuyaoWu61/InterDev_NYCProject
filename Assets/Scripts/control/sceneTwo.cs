using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class sceneTwo : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public scoreManager scoreManager;
    public float timer = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(scoreManager.currentScore <= 0){
            SceneManager.LoadScene("scene_end");
        }
        if(timer <= 0){
            SceneManager.LoadScene("scene_success");
        }
        timerText.text = timer.ToString();
    }


}
