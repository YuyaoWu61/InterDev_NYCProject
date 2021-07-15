using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void toSceneOne(){
        SceneManager.LoadScene("scene_start");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
