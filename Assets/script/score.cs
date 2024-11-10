using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
   private int Score;
   [SerializeField]Text scoretext;
    [SerializeField] Text scoretexts;

    private bool destroy;

    public void Addscore(int point)
    {
        Score += point;
        
    
        scoretext.text = Score.ToString();
        scoretexts.text = Score.ToString();

    }
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Destroyscore()
    {
        destroy = true;
    }
}
