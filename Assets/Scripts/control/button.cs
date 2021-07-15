using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button : MonoBehaviour
{
    public AudioSource bt;
    // Start is called before the first frame update
    void Start()
    {
        bt = GameObject.FindGameObjectWithTag("control").GetComponent<AudioSource>();
    }

    public void toSceneOne(){
        bt.Play();
        SceneManager.LoadScene("scene_one");
    }
    public void restart(){
        bt.Play();
        SceneManager.LoadScene("scene_start");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
