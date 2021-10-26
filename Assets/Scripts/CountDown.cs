using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public int countDown = 40;
    public Text display;

    IEnumerator CountdownToStart() {
        while (countDown > 0) {
            display.text = countDown.ToString();
            Debug.Log("Hi");
            yield return new WaitForSeconds(1f);

            countDown--;
        }

        display.text = "Bomb detonated";
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Canvas").GetComponent<CanvasGroup>().alpha = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("BombSiteA").GetComponent<Trigger>().bombStart == true)
        {
            GameObject.Find("Canvas").GetComponent<CanvasGroup>().alpha = 1f;
            StartCoroutine(CountdownToStart());
            GameObject.Find("BombSiteA").GetComponent<Trigger>().bombStart = false;
        }
        if (GameObject.Find("BombSiteB").GetComponent<Trigger>().bombStart == true) {

            GameObject.Find("Canvas").GetComponent<CanvasGroup>().alpha = 1f;
            StartCoroutine(CountdownToStart());
            GameObject.Find("BombSiteB").GetComponent<Trigger>().bombStart = false;
        }
    }
}
