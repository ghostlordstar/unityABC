using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 水平轴 X
        float horizontal = Input.GetAxis("Horizontal");
        // 垂直轴 Z
        float vertical = Input.GetAxis("Vertical");
        // 向量
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        if (movement != Vector3.zero)
        {
            // 面向向量
            transform.rotation = Quaternion.LookRotation(movement);
            // 播放跑步动画
            animator.SetBool("IsRun", true);
            // 朝向前方移动
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }else
        {
            // 播放站立动画
            animator.SetBool("IsRun", false);
        }
        
        // 获取test的参数数值
        // Debug.Log(animator.GetFloat("Test"));
    }

    void leftFoot()
    {
        Debug.Log("左脚");
    }

    void rightFoot()
    {
        Debug.Log("右脚");
    }
}
