using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void toSceneOne(){
        SceneManager.LoadScene("scene_one");
    }
    public void restart(){
        SceneManager.LoadScene("scene_start");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
