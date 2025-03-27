using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyTest : MonoBehaviour
{

    public GameObject Cube;
    public GameObject Prefab; // 预设体
    
    // Start is called before the first frame update
    void Start()
    {
        // 获取当前脚本所挂载的游戏物体
        GameObject go = this.gameObject;
        Debug.Log("name: " + go.name);
        Debug.Log("tag: " + go.tag);
        Debug.Log("layer: " + go.layer);
        
        // 立方体的信息
        Debug.Log(Cube.name);
        // 当前真正的激活状态
        Debug.Log(Cube.activeInHierarchy);
        // 当前自身的激活状态
        Debug.Log(Cube.activeSelf);
        // 获取transform组件
        Debug.Log(transform);
        // 获取其他组件
        BoxCollider bc = GetComponent<BoxCollider>();
        // 获取当前物体子物体身上的某个组件
        GetComponentInChildren<BoxCollider>(Cube);
        // 获取当前物体的父物体身上的某个组件
        GetComponentInParent<BoxCollider>(Cube);
        // 添加组件
        Cube.AddComponent<AudioSource>();
        
        
        // 其他方式获取游戏物体
        // 通过名称获取
        GameObject test = GameObject.Find("Test");
        Debug.Log("name: " + test.name);
        // 通过tag获取游戏物体
        GameObject test2 = GameObject.FindGameObjectWithTag("Enemy");
        Debug.Log("test2 name: " + test2.name);
        // 设置激活状态
        test2.SetActive(true);
        
        // 使用代码生成游戏物体
  
        // 通过预设体创建游戏物体
        GameObject tmp = Instantiate(Prefab, Vector3.zero, Quaternion.identity);
        // 销毁物体, 延迟3秒后执行
        Destroy(tmp, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
