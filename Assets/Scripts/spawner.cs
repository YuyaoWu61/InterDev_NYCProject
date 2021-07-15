using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public int Count;
    public float timer = 1f;
    
    public GameObject berry;
    public GameObject star;    
    public bool spawnStar = false;
    public Scene currentScene;

    public sceneOne sceneOne;
    void Start()
    {
        // GameObject berry = GameObject.Find("wildberry");
        currentScene = SceneManager.GetActiveScene();
        if(currentScene.name == "scene_one"){
            for(int i=0; i<5; i++){
                float spawnY = Random.Range(-10, -5);
                float spawnX = Random.Range(-25, 20);
                Vector2 spawnPos = new Vector2(spawnX, spawnY);
                GameObject.Instantiate(berry, spawnPos, Quaternion.identity);
            }
        }
        if(currentScene.name == "scene_two"){
            spawnStar = true;
        }

        
        
    }

   

    // Update is called once per frame
    void Update()
    {
        if(spawnStar == true){
            Count = GameObject.FindGameObjectsWithTag ("star").Length;
            timer -= Time.deltaTime;
            if(Count/3 <= 10){
                if(timer<=0){
                    SpawnStar();
                    SpawnStar();
                    timer = 1f;
                }
            }
        }
        // if(spawn){
        //     SpawnBerry(berry);
        //     spawn = false;
        // }
 
        // GameObject wildberry = GameObject.Find("wildberry");
        // GameObject[] berryList = GameObject.FindGameObjectsWithTag ("wildberry");

        
    } 
    public void SpawnBerry(){      
        float spawnY = Random.Range(-10, -5);
        float spawnX = Random.Range(-25, 20);
        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        // GameObject wildberry = GameObject.Find("wildberry");
        // GameObject newBerry = 
        Instantiate(berry, spawnPos, Quaternion.identity);
        // GameObject.Instantiate(berry, spawnPos, Quaternion.identity); 
    }

    public void SpawnStar(){
        float spawnY = Random.Range(-6, 6);
        float spawnX = Random.Range(20,21);
        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        GameObject newStar = Instantiate(star, spawnPos, Quaternion.identity);
        Rigidbody2D starRB = newStar.GetComponent<Rigidbody2D>();
        AudioSource meteor = newStar.GetComponent<AudioSource>();
        meteor.Play();
        Debug.Log("played");
        starRB.velocity = new Vector2(Random.Range(-13,-5),starRB.velocity.y);
        Destroy(newStar, 6f);
    }
}
