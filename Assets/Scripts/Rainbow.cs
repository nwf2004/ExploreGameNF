using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbow : MonoBehaviour
{

    public GameObject Bullet;
    public float red = 1.0f;
    public float green = 0.0f;
    public float blue = 0.0f;
    public bool colorReady = true;
    IEnumerator Coroutine()
    {


        colorReady = false;
        if (red == 1f && green < 1f && blue == 0f)
        {
            green += .1f;
        }
        else if (red > 0f && green == 1f && blue == 0f)
        {
            red += -.1f;
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
        else {

        }
        yield return new WaitForSeconds(.1f);
        Debug.Log(red);
        Debug.Log(green);
        Debug.Log(blue);
        colorReady = true;


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bullet.GetComponent<Renderer>().material.color = new Color(red, green, blue);
        StartCoroutine(Coroutine());

        if (colorReady == true)
        {
            StartCoroutine(Coroutine());
        }

    }
    
}
