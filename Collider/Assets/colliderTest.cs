using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderTest : MonoBehaviour
{
    
    // 创建一个爆炸的预设体
    public GameObject Prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 监听发生碰撞
    private void OnCollisionEnter(Collision other)
    {
        // 创建一个爆炸物体
        Instantiate(Prefab, transform.position, Quaternion.identity);
        // 销毁自己
        Destroy(gameObject);
        // 获取碰撞到的物体
        Debug.Log(other.gameObject.name);
    }
    
    // 监听持续碰撞
    private void OnCollisionStay(Collision other)
    {
        // throw new NotImplementedException();
    }
    
    // 结束碰撞
    private void OnCollisionExit(Collision other)
    {
        // throw new NotImplementedException();
    }
}
