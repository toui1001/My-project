using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private pipe pipePrefab; // �v���n�u���w��
    private float elapsedTime = 0; // �o�ߎ��Ԃ̃J�E���^�[
    private int kazu = 0; // �p�C�v�����J�E���^�[
    private bool nor = true;
    private bool strats;

    // Start�̓Q�[���J�n���Ɉ�x�����Ă΂��
    void Start()
    {
       
    }

    // Update�͖��t���[���Ă΂��
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

        if (strats) // strats��true�̂Ƃ���������
        {
            elapsedTime += Time.deltaTime; // �o�ߎ��Ԃ����Z
            if (elapsedTime > 2)
            {
                int randomInt = Random.Range(0, 3); // ���񃉃��_���Ȑ��𐶐�

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
                        spawnPosition = transform.position; // �f�t�H���g�P�[�X
                        break;
                }

                Instantiate(pipePrefab, spawnPosition, Quaternion.identity); // �p�C�v�𐶐�
                elapsedTime = 0; // �o�ߎ��Ԃ����Z�b�g
            }
        }
    }
    public void huragu()
    {
        strats = true;
    }
}
