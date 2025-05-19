using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 设置点线段位置
        // 获取线段渲染器
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 3;
        lineRenderer.SetPosition(0, Vector3.zero);
        lineRenderer.SetPosition(1, Vector3.one);
        lineRenderer.SetPosition(2, Vector3.down);
        // 颜色
        lineRenderer.startColor = Color.red;
        lineRenderer.endColor = Color.green;
        // 拖尾
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
