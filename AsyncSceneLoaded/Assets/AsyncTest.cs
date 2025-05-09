using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsyncTest : MonoBehaviour
{
    private AsyncOperation operation;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadScene());
    }

    IEnumerator loadScene()
    {
        operation = SceneManager.LoadSceneAsync(1);
        // 加载完成场景不要自动跳转
        operation.allowSceneActivation = false;
        yield return operation;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("progress: " + operation.progress);
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            operation.allowSceneActivation = true;
        }
    }
}
