using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float Up;
    [SerializeField] private score Score;
   gamemanager Gamemanager;
    private bool des = false;
    private float speed;
    private bool test = false;
    private float time = 0;
    private bool aaaa = true;
    private bool Rb = false;
    private bool dddd = false;
    private bool UPflag;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Gamemanager = FindObjectOfType<gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dddd)
        {
            ApplyGravity();
        }
        if (transform.position.y < -14 || transform.position.y > 14)
        {
            aaaa = false;
            if (aaaa != true)
            {
                Gamemanager.GameOver();
                des = true;
                aaaa = true;
            }
        }
        if (des)
        {
            return;
        }

        if (UPflag && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity =  new Vector3(0,Up,0);
        }
        if (test == false && Input.GetKeyDown(KeyCode.F))
        {
           
            Debug.Log("5�b�Ԗ��G�ł�");
            test = true;
        }
        if (test)
        {
            time += Time.deltaTime;
            if (time > 5)
            {
                Debug.Log("���ʂ��؂�܂���");
                test = false;
                time = 0;
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (test == false)
        {
            Gamemanager.GameOver();//�v���C���[�������ɂ���������gamemanager�ɔ��
            des = true;
            Score.Destroyscore();
        }
       
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (des)
        {
            return;
        }
        Score.Addscore(1);
        
    }
    public void saiki()
    {
        des = false;
        UPflag = true;
        //des = true;
    }
    public void ApplyGravity()                
    {
        UPflag = true;
        dddd = true;
        // �����ŏd�͂�������B-9.81�͒ʏ�̒n���̏d�͉����x
        rb.AddForce(Vector2.down * 3.81f, ForceMode2D.Force);
    }
}
