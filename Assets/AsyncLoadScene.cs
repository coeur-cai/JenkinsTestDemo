using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AsyncLoadScene : MonoBehaviour {
    public Text loadingText;
    public Image progressBar;

    private int curProgressValue = 0;

    private AsyncOperation operation;
    // Use this for initialization
    void Start () {
        if (SceneManager.GetActiveScene().name == "SceneB")
        {
            //启动协程
            StartCoroutine(AsyncLoading());
        }
    }
    IEnumerator AsyncLoading()
    {
        operation = SceneManager.LoadSceneAsync(2);
        //阻止当加载完成自动切换
        operation.allowSceneActivation = false;

        yield return operation;
    }

    // Update is called once per frame
    void Update () {
        //更新进度条的数值
        int progressValue = 100;

        if (curProgressValue < progressValue)
        {
            curProgressValue++;
        }
        //实时更新进度百分比的文本显示  
        loadingText.text = curProgressValue + "%";
        //实时更新滑动进度图片的fillAmount值 
        progressBar.fillAmount = curProgressValue / 100f; 

        if (curProgressValue == 100)
        {
            Debug.Log("ccccc");
            //启用自动加载场景
            operation.allowSceneActivation = true;
            //文本显示完成OK  
            loadingText.text = "OK";

        }
    }
}
