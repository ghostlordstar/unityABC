using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    
    // Audio clip
    public AudioClip audio1;
    public AudioClip audio2;
    
    // audio source
    private AudioSource player;
    
    // Start is called before the first frame update
    void Start()
    {
        // 获取播放器
        player = GetComponent<AudioSource>();
        // 播放音频片段
        player.clip = audio1;
        // 循环播放
        player.loop = true;
        // 音量
        player.volume = 0.5f;
        // 开始播放
        player.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // 按空格切换音乐播放暂停
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (player.isPlaying)
            {
                player.Pause(); // 暂停
                // player.Stop();  // 停止
            }
            else
            {
                player.Play(); // 从头播放
                player.UnPause(); // 继续播放
            }
        }
        
        // 播放音效
        if (Input.GetKeyDown(KeyCode.R))
        {
            // 播放一次
            player.PlayOneShot(audio2);
        }
    }
}
