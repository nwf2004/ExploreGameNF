using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GreenDoor")
        {
            if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 2 || GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 6)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "RedDoor")
        {
            if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 3 || GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 6)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "YellowDoor")
        {
            if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 4 || GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 6)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "BlueDoor")
        {
            if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 5 || GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 6)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }

}
