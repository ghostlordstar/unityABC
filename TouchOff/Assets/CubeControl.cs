using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // 开始触发
    private void OnTriggerEnter(Collider other)
    {
        GameObject door = GameObject.Find("Door");
        if (door != null)
        {
            // 隐藏
            door.SetActive(false);
        }
    }

    // 持续触发
    private void OnTriggerStay(Collider other)
    {
        
    }

    // 触发结束
    private void OnTriggerExit(Collider other)
    {
        
    }
}
