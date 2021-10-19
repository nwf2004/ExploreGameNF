using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerT : MonoBehaviour
{

    public bool gameEnd = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameObject.Find("BombSiteA").GetComponent<Trigger>().bombPlanted == true) {
            gameEnd = true;
            SceneManager.LoadScene("EndScreen");
        }
        else if (GameObject.Find("BombSiteB").GetComponent<Trigger>().bombPlanted == true)
        {
            gameEnd = true;
            SceneManager.LoadScene("EndScreen");
        }
    }
}