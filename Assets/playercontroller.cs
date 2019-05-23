using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rbtwod;
    public float movespeed = 8f;
    public bool grounded = false;

    public void FixedUpdate(){
        float horizontal = Input.GetAxisRaw("Horizontal");

        Cursor.visible = false;
        if(Input.GetKeyDown(KeyCode.R)){
            RestartScene();
        }
        if(Input.GetKey(KeyCode.Space) && grounded == true){
            if(rbtwod.gravityScale == 5){
            rbtwod.gravityScale = -5;
            player.transform.localScale = new Vector3(player.transform.localScale.x,-.8f,1);
            }
            else if(rbtwod.gravityScale == -5){
            rbtwod.gravityScale = 5;
            player.transform.localScale = new Vector3(player.transform.localScale.x,.8f,1);
            }
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            player.transform.localScale = new Vector3(.5f,player.transform.localScale.y,1);
            rbtwod.velocity = new Vector2(horizontal * movespeed, rbtwod.velocity.y);
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            player.transform.localScale = new Vector3(-.5f,player.transform.localScale.y,1);
            rbtwod.velocity = new Vector2(-horizontal * -movespeed, rbtwod.velocity.y);
        }
        else {rbtwod.velocity = new Vector2(0, rbtwod.velocity.y);}
    }
    public void OnTriggerStay2D(Collider2D other){
        if(other.gameObject.tag == "ground"){
            grounded = true;
        }
        else{grounded = false;}
    }
    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "ground"){
            grounded = true;
        }
        if(other.gameObject.tag == "quickandsuddendeathyounerd"){
            RestartScene();
        }
        else{grounded = false;}
    }
    public void OnTriggerExit2D(Collider2D other){
        grounded = false;
    }
    public void RestartScene(){
        SceneManager.LoadScene(0);
    }
}