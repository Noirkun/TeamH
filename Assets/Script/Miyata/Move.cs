using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Camera MapCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
       if(MapCamera.enabled == true)//マップのカメラがオンのとき
        {
             if(Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(0,0,0.02f);
        }
        if(Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(-0.02f,0,0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(0,0,-0.02f);
        }
        if(Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(0.02f,0,0);
        }
        }
       


    }
}
