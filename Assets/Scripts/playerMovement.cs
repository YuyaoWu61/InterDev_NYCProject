using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playerMovement : MonoBehaviour
{
    public float movementSpeed = 1f;
    public bool isGrounded;
    public Rigidbody2D playerRB;
    public AudioSource coin;
    public AudioSource bird;
    public scoreManager scoreManager;
    public spawner spawner;
    public GameObject berry;
    public int scoreModifier;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        isGrounded = true;
        scoreModifier = 1;
        scoreManager = GetComponent<scoreManager>();
        coin = GameObject.FindGameObjectWithTag("wildberry").GetComponent<AudioSource>();
        bird = GameObject.FindGameObjectWithTag("control").GetComponent<AudioSource>();
    }
    void Update()
        {
            // GameObject wildberry = GameObject.Find("wildberry");
        }
        
   void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "ground"){
            isGrounded = true;
        }
        if(collision.gameObject.tag == "sky"){
            isGrounded = false;
        }
        if(collision.gameObject.tag == "wildberry"){
            scoreManager.addBerry(scoreModifier);
            coin.Play();
            Destroy(collision.gameObject);
            spawner.SpawnBerry();
        }
        if(collision.gameObject.tag == "bird"){
            if(scoreManager.currentBerry >= 5){
                // bird = collision.gameObject.GetComponent<AudioSource>();
                bird.Play();
                Destroy(collision.gameObject);
                scoreManager.currentBerry -= 5;
                scoreManager.currentBirds += 1;
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision){
        if(collision.gameObject.name == "ground"){
            isGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.tag == "ground"){
            isGrounded = false;
        }
    }
   

    void FixedUpdate(){
     
        if(Input.GetKey(KeyCode.LeftArrow))
        {
        
            transform.Translate(Vector3.left * movementSpeed);
            // playerRB.AddForce(Vector2.left * movementSpeed, ForceMode2D.Force);
            // playerRB.velocity = new Vector2(-1, playerRB.velocity.y) * movementSpeed;
            GetComponent<Animator>().Play("playera");
    
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Translate(Vector3.right * movementSpeed);
            //playerRB.AddForce(Vector2.right * movementSpeed, ForceMode2D.Force);
            //playerRB.velocity = new Vector2(1, playerRB.velocity.y) * movementSpeed;
            GetComponent<Animator>().Play("playerd");
        
        }
        else if(Input.GetKey(KeyCode.UpArrow) && isGrounded)
        {
            transform.Translate(Vector3.up * movementSpeed);
            //playerRB.AddForce(Vector2.up * movementSpeed, ForceMode2D.Force);
            //playerRB.velocity = new Vector2(playerRB.velocity.x, 1) * movementSpeed;
            GetComponent<Animator>().Play("playerw");
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
        
            transform.Translate(Vector3.down * movementSpeed);
            //playerRB.AddForce(Vector2.down * movementSpeed, ForceMode2D.Force);
            //playerRB.velocity = new Vector2(playerRB.velocity.x, -1) * movementSpeed;
            GetComponent<Animator>().Play("players");
            
        }else{
            GetComponent<Animator>().Play("players");
        }
       
        
    }

 

}



        // if(Input.GetKey(KeyCode.LeftArrow))
        // {
        //     //if(isGrounded){
        //         transform.Translate(Vector3.left * movementSpeed);
        //         //playerRB.AddForce(Vector2.left * movementSpeed);
        //         GetComponent<Animator>().Play("playera");
        //     //}
        // }
        // else if(Input.GetKey(KeyCode.RightArrow))
        // {
        //     //if(isGrounded){
        //         transform.Translate(Vector3.right * movementSpeed);
        //         //playerRB.AddForce(Vector2.right * movementSpeed);
        //         GetComponent<Animator>().Play("playerd");
        //     //}
        // }
        // else if(Input.GetKey(KeyCode.UpArrow))
        // {
        //     if(isGrounded){
        //         transform.Translate(Vector3.up * movementSpeed);
        //         //playerRB.AddForce(Vector2.up * movementSpeed);
        //         GetComponent<Animator>().Play("playerw");
        //     }else{
        //     transform.Translate(Vector3.down * movementSpeed);  
        //     //isGrounded = true; 
        //     }
        // }
        // else if(Input.GetKey(KeyCode.DownArrow))
        // {
        //     if(isGrounded){
        //         transform.Translate(Vector3.down * movementSpeed);
        //         //playerRB.AddForce(Vector2.down * movementSpeed);
        //         GetComponent<Animator>().Play("players");
        //     }else{
        //     transform.Translate(Vector3.down * movementSpeed);  
        //     //isGrounded = true; 
        //     }
        // }else{
        //     GetComponent<Animator>().Play("players");
        // }
        
        // // else{
        // //     transform.Translate(Vector3.down * movementSpeed);  
        // //     //isGrounded = true; 
        // // }