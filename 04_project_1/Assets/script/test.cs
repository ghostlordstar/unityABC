using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Awake 是组件最先调用的方法");
    }

    // 组件前面的复选框被选中时就是被激活
    private void OnEnable()
    {
        Debug.Log("onEnable 是组件被激活时调用的方法");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start 脚本运行时调用一次");
    }

    private void FixedUpdate()
    {
        // 默认0.02秒调用一次
        // 可以去项目设置-时间-固定时间步进-调整
        // Debug.Log("FixedUpdate 固定时间刷新，与帧无关");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update 每帧调用一次");   
    }

    private void LateUpdate()
    {
        // Debug.Log("LateUpdate 每次Update调用后调用一次");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable方法组件被禁用时调用");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy方法组件被销毁（移除）时调用");
    }

}
