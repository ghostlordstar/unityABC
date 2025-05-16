using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // 水平轴
        float horizontal = Input.GetAxis("Horizontal");
        // 垂直轴
        float vertical = Input.GetAxis("Vertical");
        // 创建一个方向向量
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        Debug.DrawRay(transform.position, dir, Color.red);
        // 朝向该方向移动
        player.SimpleMove(dir * 2);
    }
}
