using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    
    public Transform target;
    
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 获取x轴
        float horizontal = Input.GetAxis("Horizontal");
        // 获取y轴
        float vertical = Input.GetAxis("Vertical");
        // 组成向量
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        // 移动
        if (movement != Vector3.zero)
        {
            // 移动并播放行走动画
            transform.rotation = Quaternion.LookRotation(movement);
            animator.SetBool("isRun", true);
            transform.Translate(Vector3.forward * Time.deltaTime * 2);
        }
        else
        {
            // 站立并播放站立动画
            animator.SetBool("isRun", false);
        }
    }

    private void OnAnimatorIK(int layerIndex)
    {
        // 设置权重
        animator.SetLookAtWeight(1);
        // 设置朝向
        animator.SetLookAtPosition(target.position);
        
        // 设置右手权重
        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        // 设置旋转权重
        animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
        // 设置右手朝向
        animator.SetIKPosition(AvatarIKGoal.RightHand, target.position);
        // 设置右手旋转
        animator.SetIKRotation(AvatarIKGoal.RightHand, target.rotation);
    }
}
