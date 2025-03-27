using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 可以代表向量、坐标、旋转、缩放
        Vector3 v = new Vector3(1, 2, 3);
        v = Vector3.zero; // 初始化为(0, 0, 0)的结构体
        v = Vector3.one; // 初始化为(1, 1, 1)的结构体
        v = Vector3.right; // 初始化为(1, 0, 0)的结构体

        Vector3 v2 = Vector3.forward; // 初始化为(0, 0, 1)的结构体
        
        // 计算两个向量的夹角
        float angle = Vector3.Angle(v, v2);
        Debug.Log("angle: " + angle);

        // 计算两个点的距离
        float distance = Vector3.Distance(v, v2);
        Debug.Log("distance: " + distance);

        // 点乘
        float dot = Vector3.Dot(v, v2);
        Debug.Log("dot: " + dot);

        // 叉乘
        Vector3 cross = Vector3.Cross(v, v2);
        Debug.Log("cross: " + cross);

        // 差值(比例)
        Vector3 lerp = Vector3.Lerp(Vector3.zero, Vector3.one, 0.5f);
        Debug.Log("lerp: " + lerp);

        // 向量的模
        Debug.Log("magnitude" + v.magnitude);

        // 归一化/单位化/规范化
        Vector3 normalized = v.normalized;
        Debug.Log("normalized: " + normalized);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
