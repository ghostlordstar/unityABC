using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 游戏数据文件夹路径，只读（打包后被压缩加密）
        Debug.Log(Application.dataPath);
        // 持久化文件夹路径
        Debug.Log(Application.persistentDataPath);
        // 只读，打包后不会被压缩，加密
        Debug.Log(Application.streamingAssetsPath);
        // 临时文件
        Debug.Log(Application.temporaryCachePath);
        // 控制是否在后台运行
        Debug.Log(Application.runInBackground);
        // 打开一个链接
        Application.OpenURL("https://www.baidu.com");
        // 退出游戏
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
