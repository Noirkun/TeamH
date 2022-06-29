using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Camera _camera; //メインカメラ
    public Camera MapCamera; //マップのカメラ
    // Start is called before the first frame update
    void Start()
    {
        //マップのカメラをオフにしておく
        MapCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //キーが押されたとき
        if(Input.GetKeyDown(KeyCode.Q))
        {
            
          
            if (!MapCamera.enabled)
        {
            //マップカメラをオンにして
            MapCamera.enabled = true;
 
            //カメラをオフにする
            _camera.enabled = false;
    
        }
        //もしマップカメラがオンだったら
        else
        {
            //マップカメラをオフにして
            MapCamera.enabled = false;
 
            //カメラをオンにする
            _camera.enabled = true;   

        }
        }
        
        
    }
}

