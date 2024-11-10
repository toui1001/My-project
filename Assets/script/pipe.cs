using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float time = 5;
    private float times;
    private float newtest = 1;
    [SerializeField] private float speed;
    private bool test = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (test)
        {
            times += Time.deltaTime;
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            if (time < times)
            {
                Destroy(gameObject);
            }
        }
    }
}
