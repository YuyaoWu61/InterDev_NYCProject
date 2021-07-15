using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneOne : MonoBehaviour
{
    public scoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreManager.currentBirds == 4){
            // DontDestroyOnLoad(this);
            SceneManager.LoadScene("scene_two");
        }
    }
}
