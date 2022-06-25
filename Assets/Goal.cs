using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    //ゴールの場所にからのオブジェクトを置いて、そのオブジェクトにColliderを
    //つけてIsTriggerにチェックを入れてください。
 
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Title");
    }
}
