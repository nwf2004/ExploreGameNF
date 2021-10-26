using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerMove : MonoBehaviour
{


    Rigidbody2D myBody;

    public bool hasBomb = false;
    public float speed;
    public float dist;
    public bool hasGun1 = true;
    public bool hasGun2 = false;
    public bool hasGun3 = false;
    public bool hasGun4 = false;
    public bool hasGun5 = false;
    public bool hasGun6 = false;
    public int currentGun = 0;

    // Start is called before the first frame update
    void Start()
    {
        hasGun1 = true;
        currentGun = 1;
        myBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckKeys();
        SwitchGuns();
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

    void SwitchGuns()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (hasGun1 == true) {
                currentGun = 1;   
            }
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (hasGun2 == true)
            {
                currentGun = 2;
            }
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            if (hasGun3 == true)
            {
                currentGun = 3;
            }
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            if (hasGun4 == true)
            {
                currentGun = 4;
            }
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            if (hasGun5 == true)
            {
                currentGun = 5;
            }
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            if (hasGun6 == true)
            {
                currentGun = 6;
            }
        }
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
        if (collision.gameObject.name == "Gun")
        {
            hasGun2 = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Gun2")
        {
            hasGun3 = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Gun3")
        {
            hasGun4 = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Gun4")
        {
            hasGun5 = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "RainbowGun")
        {
            hasGun5 = true;
            Destroy(collision.gameObject);
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
