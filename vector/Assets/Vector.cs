using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{

    // 标量：只有大小的量。
    // 向量：有大小和方向的量。
    // 向量的模：向量的大小。
    // 单位向量：大小为1的向量。
    // 单位化，归一化：将向量转化为单位向量。 

    // 向量的加法：将两个向量的对应分量相加。
    // 遵循平行四边形法则。
    /*
    a = (x1, y1)
    b = (x2, y2)
    a + b = (x1 + x2, y1 + y2)
    */

    // 向量的减法：将两个向量的对应分量相减。
    // 被减向量向减数向量的方向。
    /*
    a = (x1, y1)
    b = (x2, y2)
    a - b = (x1 - x2, y1 - y2)
    */

    // 向量乘法：
    // 乘标量：将向量的每个分量乘以一个标量。
    /*
    a = (x, y)
    k = 2
    k * a = (2x, 2y)
    */

    // 点乘：两个向量的对应分量相乘再相加。
    /*
    a = (x1, y1)
    b = (x2, y2)
    a · b = x1 * x2 + y1 * y2 = |a| * |b| * cosθ
    // 可以通过计算获取两个向量的夹角。
    θ = arccos((a · b) / (|a| * |b|))
    如果a、b是单位向量，那么a · b = cosθ
    θ = arccos(a · b)
    */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
