using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scene : MonoBehaviour
{

    PipeSpawner pipeSpawner;
    player Player;
    gamemanager Gamemanager;
   
    
    void Start()
    {
       
        Gamemanager = FindObjectOfType<gamemanager>();
        Player = FindObjectOfType<player>();
        pipeSpawner = FindObjectOfType<PipeSpawner>();
        if (pipeSpawner == null)
        {
            Debug.LogError("PipeSpawnerが見つかりません。コンポーネントを確認してください。");
        }
    }

    public void botandown()
    {
        Gamemanager.score();
        Player.ApplyGravity();
        pipeSpawner.huragu();
        gameObject.SetActive(false);
       
    }
}
