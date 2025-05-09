using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 鼠标的点击
        // 按下鼠标 0左键，1右键，2中键或滚轮
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("按下了鼠标左键");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("持续按下了鼠标左键");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("抬起了鼠标左键");
        }
        
        // 键盘按键按下
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("按下了键盘A键");
        }
        
        // 键盘按键按下
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("持续按下了键盘A键");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("抬起了键盘A键");
        }
    }
}
