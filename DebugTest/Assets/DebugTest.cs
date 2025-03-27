using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("普通日志");
        Debug.LogWarning("警告日志");
        Debug.LogError("错误日志");
    }

    // Update is called once per frame
    void Update()
    {
        // 绘制一条线
        Debug.DrawLine(Vector3.zero, Vector3.one, Color.red);
        // 绘制一条射线
        Debug.DrawRay(Vector3.zero, Vector3.up, Color.blue);
    }
    
}
