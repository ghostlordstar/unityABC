using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 方式1
        Ray ray = new Ray(Vector3.zero, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 按下鼠标左键发射射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // 声明一个碰撞信息类
            RaycastHit hit;
            // 碰撞检测
            bool res = Physics.Raycast(ray, out hit);
            // 如果碰撞到
            if (res == true)
            {
                Debug.Log(hit.point);
                transform.position = hit.point;
            }
            // 多检测, 限制图层（只检测1～10图层）
            // RaycastHit[] hits = Physics.RaycastAll(ray, 1<<10);
        }
    }
}
