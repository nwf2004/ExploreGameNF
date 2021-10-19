using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public bool bombPlanted = false;

    // Start is called before the first frame update
    void Start()
    {
        bombPlanted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hi");
        if (GameObject.Find("Player").GetComponent<PlayerMove>().hasBomb == true)
        {
            bombPlanted = true;
            GameObject.Find("Player").GetComponent<PlayerMove>().hasBomb = false;



        }
    }
}
