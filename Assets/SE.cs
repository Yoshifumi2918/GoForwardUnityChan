using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{

    //サウンドを取得

    public AudioClip sound;


    AudioSource audioSource;


  
   


    // Start is called before the first frame update
    void Start()
    {


        //音声のコンポーネントを取得
        audioSource = GetComponent<AudioSource>();


    }



    
    void OnCollisionEnter2D(Collision2D collision)
    
    {

        //地面に接触した時またはキューブが積み重なったとき効果音を鳴らす

        if (collision.gameObject.tag == "GroundTag" || collision.gameObject.tag == "CubeTag")
        {


            audioSource.PlayOneShot(sound);

        }



    }
}
