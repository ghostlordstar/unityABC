using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 水平轴
        float horizontal = Input.GetAxis("Horizontal");
        // 垂直轴
        float vertical = Input.GetAxis("Vertical");
        // 向量
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        // 朝向量方向移动
        transform.Translate(dir * 2 * Time.deltaTime);
    }
}
