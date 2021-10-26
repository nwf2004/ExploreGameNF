using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public bool gunReady = true;
    public GameObject beam1;
    public GameObject beam2;
    public GameObject beam3;
    public GameObject beam4;
    public GameObject beam5;
    public GameObject beam6;
    public float shootSpeed;
    GameObject newBeam;

    IEnumerator Coroutine()
    {


        gunReady = false;
        yield return new WaitForSeconds(.1f);
        gunReady = true;  

       
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && gunReady == true) {
            if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 1)
            {
                newBeam = Instantiate(beam1);
            }
            if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 2)
            {
                newBeam = Instantiate(beam2);
            }
            if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 3)
            {
                newBeam = Instantiate(beam3);
            }
            if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 4)
            {
                newBeam = Instantiate(beam4);
            }
            if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 5)
            {
                newBeam = Instantiate(beam5);
            }
            if (GameObject.Find("Player").GetComponent<PlayerMove>().currentGun == 6)
            {
                newBeam = Instantiate(beam6);
            }
            //else {
            //    newBeam = Instantiate(beam1);
            //}
            //newBeam.transform.SetParent(gameObject.transform);
            newBeam.transform.position = transform.position + (transform.right * 2);
            newBeam.transform.rotation = transform.rotation;
            Vector2 shootVector = (transform.right * shootSpeed);
            
            newBeam.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity + shootVector;
            //newBeam.GetComponent<Rigidbody2D>().velocity += transform.right * shootSpeed;
            //float dir = 0;


            //newBeam.GetComponent<Rigidbody2D>().velocity = new Vector3(dir * shootSpeed, 0f);
            StartCoroutine(Coroutine());
        }
    }
}
