using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFly : MonoBehaviour
{
    public float movementSpeed = 0.25f;
    public scoreManager scoreManager;
    public int scoreModifier = 1;
    public AudioSource meteor;
    public AudioSource crash;

    // Start is called before the first frame update
    void Start()
    {
        crash = GameObject.FindGameObjectWithTag("control").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "star"){
            crash.Play();
            Destroy(collision.gameObject);
            scoreManager.changeScore(1);
            GetComponent<Animator>().Play("playerhit");
        }
    }

    void FixedUpdate(){
     
        if(Input.GetKey(KeyCode.LeftArrow))
        {
        
            transform.Translate(Vector3.left * movementSpeed);
            GetComponent<Animator>().Play("playerfly");
    
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Translate(Vector3.right * movementSpeed);
            GetComponent<Animator>().Play("playerfly");
        
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * movementSpeed);
            GetComponent<Animator>().Play("playerfly");
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
        
            transform.Translate(Vector3.down * movementSpeed); 
            GetComponent<Animator>().Play("playerfly");
            
        }else{
            GetComponent<Animator>().Play("playerfly");
        }

    }
}
