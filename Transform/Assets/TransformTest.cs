using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        // 相对于世界的位置
        Debug.Log(transform.position);
        // 相对于父物体的位置
        Debug.Log(transform.localPosition);

        // 相对于世界的旋转角度(四元数)
        Debug.Log(transform.rotation);
        // 相对于父物体的旋转角度(四元数)
        Debug.Log(transform.localRotation);
        // 获取旋转的角度（欧拉角）vector3, 相对于世界
        Debug.Log(transform.eulerAngles);
        // 获取旋转的角度（欧拉角）Vector3, 相对于父物体
        Debug.Log(transform.localEulerAngles);

        // 获取缩放，相对于父物体
        Debug.Log(transform.localScale);

        // 方向
        Debug.Log(transform.forward);
        Debug.Log(transform.right);
        Debug.Log(transform.up);
        */

        // 父子关系
        Debug.Log("name: " + transform.parent.gameObject.name);
        // 获取子物体的个数
        Debug.Log("count: " + transform.childCount);
        // 解除子物体的关系
        // transform.DetachChildren();
        // 通过名字获取子物体
        Transform trans = transform.Find("Child");
        Debug.Log(trans.name);
        // 通过索引获取子物体
        trans = transform.GetChild(0);
        // 判断某个游戏物体是否是某个物体的子物体
        bool isChild = trans.IsChildOf(transform);
        Debug.Log(isChild);
        
        // 设置为父物体
        trans.SetParent(transform);
    }

    // Update is called once per frame
    void Update()
    {
        // 时刻看向0,0,0 （原点）
        // transform.LookAt(Vector3.zero);
        
        /*
         * 绕某个轴旋转
         * 旋转角度
         */
        // transform.Rotate(Vector3.up, 1);
        
        /*
         * point: 围绕的点
         * axis: 围绕的点的轴
         * angle: 旋转的角度
         */
        // transform.RotateAround(Vector3.zero, Vector3.up, 1);   
        
        
        /*
         * 移动, 移动方向和速度
         */
        // transform.Translate(Vector3.forward * 0.1f);
    }
    
    
}
