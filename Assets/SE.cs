using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{

    //�T�E���h���擾

    public AudioClip sound;


    AudioSource audioSource;


  
   


    // Start is called before the first frame update
    void Start()
    {


        //�����̃R���|�[�l���g���擾
        audioSource = GetComponent<AudioSource>();


    }



    
    void OnCollisionEnter2D(Collision2D collision)
    
    {

        //�n�ʂɐڐG�������܂��̓L���[�u���ςݏd�Ȃ����Ƃ����ʉ���炷

        if (collision.gameObject.tag == "GroundTag" || collision.gameObject.tag == "CubeTag")
        {


            audioSource.PlayOneShot(sound);

        }



    }
}
