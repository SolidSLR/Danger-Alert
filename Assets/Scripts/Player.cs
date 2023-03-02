using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private bool isJumping;
    private Vector3 newPosition;
    private string direction;
    // Start is called before the first frame update
    void Start()
    {
     rb = gameObject.GetComponent<Rigidbody2D>();
     newPosition = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 prevPos = transform.position;
        //Debug.Log("Posición previa: "+prevPos);        
        if(!isJumping){
            direction = "";
            if(Input.GetKey(KeyCode.D)){
                newPosition = Vector3.right * speed * Time.deltaTime;
                rb.transform.position += newPosition;
                direction = "d";
            }
            if(Input.GetKey(KeyCode.A)){
                newPosition = Vector3.left * speed * Time.deltaTime;
                rb.transform.position += newPosition;
                direction = "a";
            }
            if(Input.GetKeyDown(KeyCode.Space)){
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }

        if(isJumping){
            if(direction == "a"){
                newPosition = Vector3.left * speed * Time.deltaTime;
                rb.transform.position += newPosition;
            }else if(direction == "d"){
                newPosition = Vector3.right * speed * Time.deltaTime;
                rb.transform.position += newPosition;
            }
        }
        //Debug.Log("Posición actual: "+transform.position);
    }

    void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Ground"){
            isJumping = false;
        }
    }
}
