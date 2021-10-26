using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public GameObject BombText;
    public GameObject RunText;

    // Start is called before the first frame update
    void Start()
    {
        BombText.GetComponent<Text>().enabled = false;
        RunText.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player").GetComponent<PlayerMove>().hasBomb == true)
        {

            BombText.GetComponent<Text>().enabled = true;
        }
        else
        {
            BombText.GetComponent<Text>().enabled = false;
        }
        if (GameObject.Find("BombSiteA").GetComponent<Trigger>().bombPlanted == true) {
            RunText.GetComponent<Text>().enabled = true;
        }
        if (GameObject.Find("BombSiteB").GetComponent<Trigger>().bombPlanted == true)
        {
            RunText.GetComponent<Text>().enabled = true;
        }
    }
}
