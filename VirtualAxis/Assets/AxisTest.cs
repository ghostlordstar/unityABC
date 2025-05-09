using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 获取水平轴
        float horizontal = Input.GetAxis("Horizontal");
        // 获取垂直轴
        float vertical = Input.GetAxis("Vertical");
        Debug.Log("h:" + horizontal + ", v:" + vertical);
        
        
        // 获取虚拟按键
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("虚拟按键 按下，空格");
        }

        if (Input.GetButton("Jump"))
        {
            Debug.Log("虚拟按键 连续 空格");
        }

        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("虚拟按键 抬起 空格");
        }
    }
}
