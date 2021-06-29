using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public int berryCount;
    public float timer = 3f;

    // public GameObject berries;
    public GameObject berry;    
    public bool spawn = false;
    void Start()
    {
        // GameObject berry = GameObject.Find("wildberry");
    }

   

    // Update is called once per frame
    void Update()
    {
        // if(spawn){
        //     SpawnBerry(wildberry);
        //     spawn = false;
        // }
 
        // GameObject wildberry = GameObject.Find("wildberry");
        // GameObject[] berryList = GameObject.FindGameObjectsWithTag ("wildberry");

        // berryCount = GameObject.FindGameObjectsWithTag ("wildberry").Length;
        // while(berryCount <= 20){
        //     timer -= Time.deltaTime;
        //     if(timer<=0){
        //         SpawnBerry();
        //         timer = 3f;
        //     }
        // }
    } 
    public void SpawnBerry(GameObject berry){
        
        float spawnY = Random.Range(-10, -5);
        float spawnX = Random.Range(-25, 20);
        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        // GameObject wildberry = GameObject.Find("wildberry");
        // GameObject newBerry = GameObject.Instantiate(berry, spawnPos, Quaternion.identity);
        
        // Instantiate(berry, spawnPos, Quaternion.identity);
        Instantiate(Resources.Load("YOURPATH", typeof(GameObject)));
    }
}
