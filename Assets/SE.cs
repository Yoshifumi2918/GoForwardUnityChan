using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{

    //�T�E���h���擾

    public AudioClip sound;


    AudioSource audioSource;

    //���o���̔���

    private bool isSound = true;
  
   


    // Start is called before the first frame update
    void Start()
    {


        //�����̃R���|�[�l���g���擾
        audioSource = GetComponent<AudioSource>();


    }



    
    void OnCollisionEnter2D(Collision2D collision)
    
    {

        //�n�ʂɐڐG�������L���[�u�̌��ʉ���炷

        if (collision.gameObject.tag == "GroundTag")

            this.isSound = true;

          audioSource.PlayOneShot(sound);


        //�L���[�u���ςݏd�Ȃ�Ƃ��A���ʉ��𗬂�

        if (collision.gameObject.tag == "CubeTag")

            this.isSound = true;

            audioSource.PlayOneShot(sound);




    }
}
