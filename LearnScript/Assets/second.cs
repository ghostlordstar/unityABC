using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second : MonoBehaviour
{

    // Execution Order 可以控制脚本执行顺序，数字越小越先执行

    private void Awake()
    {
        Debug.Log("Awake - second");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start - second");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
