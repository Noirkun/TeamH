using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    //�S�[���̏ꏊ�ɂ���̃I�u�W�F�N�g��u���āA���̃I�u�W�F�N�g��Collider��
    //����IsTrigger�Ƀ`�F�b�N�����Ă��������B
 
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Title");
    }
}
