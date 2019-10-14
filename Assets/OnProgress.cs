using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnProgress : MonoBehaviour {
    
    public void OnBtnClick()
    {
        Debug.Log("clicked");
        //加载进度条场景
        SceneManager.LoadScene(1);
    }
}
