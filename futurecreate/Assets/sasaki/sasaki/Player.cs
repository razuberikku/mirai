using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector3 Player_pos; //�v���C���[�̃|�W�V����

    
    private float x; //x������Imput�̒l
    private float z; //z������Input�̒l

    void Start()
    {
        Player_pos = GetComponent<Transform>().position; //�ŏ��̎��_�ł̃v���C���[�̃|�W�V�������擾
        
    }

    void Update()
    {
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.03f, 0.0f, 0.0f);
        }
        // �E�Ɉړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.03f, 0.0f, 0.0f);
        }
        // �O�Ɉړ�
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0.0f, 0.0f, 0.03f);
        }
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0.0f, 0.0f, -0.03f);
        }



        //Vector3 diff = this.transform.position - Player_pos; //�v���C���[���ǂ̕����ɐi��ł��邩���킩��悤�ɁA�����ʒu�ƌ��ݒn�̍��W�������擾


        //if (diff.magnitude > 0.01f) //�x�N�g���̒�����0.01f���傫���ꍇ�Ƀv���C���[�̌�����ς��鏈��������(0�ł͓���Ȃ��̂Łj
        //{
        //    transform.rotation = Quaternion.LookRotation(diff);  //�x�N�g���̏���Quaternion.LookRotation�Ɉ����n����]�ʂ��擾���v���C���[����]������
        //}

        //Player_pos = transform.position; //�v���C���[�̈ʒu���X�V



    }
}