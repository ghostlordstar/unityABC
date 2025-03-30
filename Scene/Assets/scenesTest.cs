using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenesTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 通过名称的方式加载场景
        // 场景跳转
        // SceneManager.LoadScene("MyScene");
        
        // 获取当前场景
        Scene curScene = SceneManager.GetActiveScene();
        Debug.Log("Scene name: " + curScene.name); 
        // 场景是否已经加载
        Debug.Log("isLoaded: " + curScene.isLoaded);
        // 场景路径
        Debug.Log("Path: " + curScene.path);
        // 场景索引
        Debug.Log("build index: " + curScene.buildIndex);
        // 所有的游戏物体
        GameObject[] objs = curScene.GetRootGameObjects(); 
        Debug.Log("游戏物体个数：" + objs.Length);
        
        // 场景管理类
        Debug.Log("当前的场景数量：" + SceneManager.sceneCount);
        // 创建新场景
        Scene newScene = SceneManager.CreateScene("NewScene");
        Debug.Log("当前的场景数量：" + SceneManager.sceneCount);
        // 卸载场景
        SceneManager.UnloadSceneAsync(newScene);
        
        // 加载场景
        // LoadSceneMode.Additive 添加到一个场景中
        // LoadSceneMode.Single 替换当前的scene
        SceneManager.LoadScene("MyScene", LoadSceneMode.Additive);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
