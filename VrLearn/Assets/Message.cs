using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    public void OnTriggerEnter(Collider other) {
        canvas.SetActive(true);
        StartCoroutine(Wait(3.0f));
    }


    IEnumerator Wait(float s) {
        yield return new WaitForSeconds(s);
        canvas.SetActive(false);
    }
}
