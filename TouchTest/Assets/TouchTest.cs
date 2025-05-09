using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 开启多点触摸
        Input.multiTouchEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
          // 获取第一个触点对象
            Touch touch = Input.touches[0];
            // 打印触摸位置
            Debug.Log("位置：" + touch.position);
            // 触摸状态
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Debug.Log("触摸开始");
                    break;
                case TouchPhase.Moved:
                    Debug.Log("触点开始移动：" + touch.position);
                    break;
                case  TouchPhase.Stationary:
                    Debug.Log("触点停止"+touch.position);
                    break;
                case TouchPhase.Ended:
                    Debug.Log("触摸停止："+touch.position);
                    break;
            }
        }

        if (Input.touchCount == 2)
        {
            // 获取第一个触点对象
            Touch touch1 = Input.touches[0];
            // 打印触摸位置
            Debug.Log("位置1：" + touch1.position);
            
            Touch touch2 = Input.touches[1];
            Debug.Log("位置2：" + touch2.position);
        }

    }
}
