using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerMove : MonoBehaviour
{


    Rigidbody2D myBody;

    public bool hasBomb = false;
    public float speed;
    public float dist;

    // Start is called before the first frame update
    void Start()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckKeys();
       
    }

    void CheckKeys()
    {
       
       
        myBody.velocity = new Vector3(0, 0);
        
        if (Input.GetKey(KeyCode.D))
        {
            HandleLRMovement(speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            HandleLRMovement(-speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            HandleUDMovement(speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            HandleUDMovement(-speed);
        }
 
        Vector3 mPos = Input.mousePosition;
        mPos = Camera.main.ScreenToWorldPoint(mPos);
        RotateSelf(mPos);

    }
    void HandleLRMovement(float direction)
    {
        myBody.velocity = new Vector3(direction, myBody.velocity.y);
    }
    void HandleUDMovement(float direction)
    {
        myBody.velocity = new Vector3(myBody.velocity.x, direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            hasBomb = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    void RotateSelf(Vector3 mousePos) {
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.right = direction;
    }
}
