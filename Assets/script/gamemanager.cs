using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class gamemanager : MonoBehaviour
{
    [SerializeField] GameObject gameovar;
    [SerializeField] GameObject gameovar1;
    //[SerializeField] Text gameovar2;
    [SerializeField] GameObject canvas;
    PipeSpawner pipeSpawner;
    player Player;
    public GameObject targetObject;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    //[SerializeField] GameObject canvas2;
    private bool test = false;
    public float yOffset = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
       pipeSpawner = FindObjectOfType<PipeSpawner>();
       Player = FindObjectOfType<player>();
        initialPosition = targetObject.transform.position;
        initialRotation = targetObject.transform.rotation;
    }
    void Update()
    {
      
       GameObject[] upObjects = GameObject.FindGameObjectsWithTag("up");   //upというタグのついたオブジェクトをupObjectsに取得
        GameObject prefabn = GameObject.Find("prefab");
        if (test && Input.GetKeyDown(KeyCode.LeftShift))
        {
            SceneManager.LoadScene("SampleScene");
            //pipeSpawner.huragu();
            //Player.saiki();
            //test = false;

        }
        if (test && Input.GetKeyDown(KeyCode.RightShift))
        {
            Player.saiki();
            int t = 0;
            //gameovar2.text = t.ToString();
            //gameovar1.GetComponent<Text>().text = t.ToString();
            gameovar1.SetActive(true);
            test = false;
            //canvas.SetActive(true);
            gameovar.SetActive(false);
            Vector3 newPosition = initialPosition;
            newPosition.y += yOffset;
            targetObject.transform.position = newPosition;
            targetObject.transform.rotation = initialRotation;
            //if (prefabn != null)
            //{
            //    //prefabn.SetActive(false);
            //}
            foreach (GameObject upObject in upObjects)
            {
                upObject.SetActive(false); // オブジェクトを非表示にする
            }
        }
    }

        public void GameOver()
    {
            gameovar.SetActive(true);
            gameovar1.SetActive(false);
            test = true;
    }

    public void score()
    {
        gameovar1.SetActive(true);
    }
}
