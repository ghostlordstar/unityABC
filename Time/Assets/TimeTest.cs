using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    // Start is called before the first frame update
    private float time = 0;
    void Start()
    {
        // 游戏开始到现在所花的时间
        Debug.Log("time1:" + Time.time);
        // 时间缩放值
        Debug.Log("time2:" + Time.timeScale);
        // 固定时间间隔
        Debug.Log("time3:" + Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        Debug.Log("delteTime: " + Time.deltaTime);
        Debug.Log("all Time: " + time);
    }

    private void FixedUpdate()
    {
        
    }
}
