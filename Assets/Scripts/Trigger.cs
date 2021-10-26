using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject doors;
    public GameObject MoreDoors;
    public bool bombPlanted = false;
    public bool bombStart = false;

    // Start is called before the first frame update
    void Start()
    {
        MoreDoors.SetActive(false);
        bombPlanted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            doors.SetActive(false);
            MoreDoors.SetActive(true);
            Debug.Log("Hi");
            if (GameObject.Find("Player").GetComponent<PlayerMove>().hasBomb == true)
            {
                bombPlanted = true;
                bombStart = true;
                GameObject.Find("Player").GetComponent<PlayerMove>().hasBomb = false;



            }
        }
    }
}
