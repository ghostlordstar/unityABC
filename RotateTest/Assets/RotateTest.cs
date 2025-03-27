using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 旋转：欧拉角、四元数
        // 转换
        Vector3 rotate = new Vector3(0, 30, 0); // 绕y轴旋转30度
        // 初始化
        Quaternion quaternion = Quaternion.identity;
        // 通过欧拉角生成四元数
        quaternion = Quaternion.Euler(rotate);
        // 看向一个物体
        quaternion = Quaternion.LookRotation(new Vector3(10, 0, 0));
        
        // 四元数转换成欧拉角
        rotate = quaternion.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
