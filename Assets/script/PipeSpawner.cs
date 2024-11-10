using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private pipe pipePrefab; // プレハブを指定
    private float elapsedTime = 0; // 経過時間のカウンター
    private int kazu = 0; // パイプ生成カウンター
    private bool nor = true;
    private bool strats;

    // Startはゲーム開始時に一度だけ呼ばれる
    void Start()
    {
       
    }

    // Updateは毎フレーム呼ばれる
    void Update()
    {
        prefab();
    }

    public void stratsa()
    {
        strats = true;
       
    }
    
    private void prefab()
    {

        if (strats) // stratsがtrueのときだけ処理
        {
            elapsedTime += Time.deltaTime; // 経過時間を加算
            if (elapsedTime > 2)
            {
                int randomInt = Random.Range(0, 3); // 毎回ランダムな数を生成

                Vector3 spawnPosition;
                switch (randomInt)
                {
                    case 0:
                        spawnPosition = transform.position;
                        break;
                    case 1:
                        spawnPosition = transform.position + new Vector3(0, 3, 0);
                        break;
                    case 2:
                        spawnPosition = transform.position + new Vector3(0, -3, 0);
                        break;
                    default:
                        spawnPosition = transform.position; // デフォルトケース
                        break;
                }

                Instantiate(pipePrefab, spawnPosition, Quaternion.identity); // パイプを生成
                elapsedTime = 0; // 経過時間をリセット
            }
        }
    }
    public void huragu()
    {
        strats = true;
    }
}
