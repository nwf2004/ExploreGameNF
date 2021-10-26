using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public float red = 1f;
    public float green = 0f;
    public float blue = 0f;
    public bool colorReady;
    IEnumerator Coroutine()
    {


        colorReady = false;
        yield return new WaitForSeconds(.1f);
        colorReady = true;


    }
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f);
        }
        if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(.11f, 1f, 0f);
        }
        if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1f, .20f, 0f);
        }
        if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 4)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 0f);
        }
        if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 5)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0f, .05f, 1f);
        }
        if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 6)
        {
            if (colorReady == true)
            {
                if (red == 1f && green < 1f && blue == 0f)
                {
                    green += .1f;
                }
                if (red > 0f && green == 1f && blue == 0f)
                {
                    red -= .1f;
                }
                if (red == 0f && green == 1f && blue < 1f)
                {
                    blue += .1f;
                }
                if (red == 0f && green > 0f && blue == 1f)
                {
                    green -= .1f;
                }
                if (red < 1f && green == 0f && blue == 0f)
                {
                    red += .1f;
                }
                if (red == 1f && green == 0f && blue > 0f)
                {
                    blue -= .1f;
                }
                gameObject.GetComponent<Renderer>().material.color = new Color(red, green, blue);
                StartCoroutine(Coroutine());
            }
        }
    }
}
    
