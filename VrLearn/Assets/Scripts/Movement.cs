using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed=20;
    //public GameObject ob;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            //ob.transform.position += new Vector3(1,0,0);
            //transform.Translate(Vector3.forward+Time.deltaTime*speed);
        }
    }
}
