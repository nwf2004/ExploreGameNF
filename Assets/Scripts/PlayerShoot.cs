using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject beam;
    public float shootSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject newBeam = Instantiate(beam);
            //newBeam.transform.SetParent(gameObject.transform);
            newBeam.transform.position = transform.position + (transform.right * 2);
            newBeam.transform.rotation = transform.rotation;
            Vector2 shootVector = (transform.right * shootSpeed);
            
            newBeam.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity + shootVector;
            //newBeam.GetComponent<Rigidbody2D>().velocity += transform.right * shootSpeed;
            //float dir = 0;
            

            //newBeam.GetComponent<Rigidbody2D>().velocity = new Vector3(dir * shootSpeed, 0f);
        }
    }
}
