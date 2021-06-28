using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float movementSpeed = 1f;
    public bool isGrounded;
    public Rigidbody2D playerRB;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

   void OnTriggerEnter2D(Collider2D collision){
        // if(collision.gameObject.tag == "ground"){
        //     Debug.Log("!!!");
        //     isGrounded = true;
        // }
        if(collision.gameObject.tag == "sky"){
            isGrounded = false;
        }
    }

    void OnTriggerStay2D(Collider2D collision){
        if(collision.gameObject.name == "ground"){
            Debug.Log("isgrounded");
            isGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.tag == "ground"){
            isGrounded = false;
        }
        

    }

    // Update is called once per frame
    void Update()
    {

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