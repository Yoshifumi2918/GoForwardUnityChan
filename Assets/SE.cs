using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{

    //サウンドを取得

    public AudioClip sound;


    AudioSource audioSource;

    //音出しの判定

    private bool isSound = true;
  
   


    // Start is called before the first frame update
    void Start()
    {


        //音声のコンポーネントを取得
        audioSource = GetComponent<AudioSource>();


    }



    
    void OnCollisionEnter2D(Collision2D collision)
    
    {

        //地面に接触した時キューブの効果音を鳴らす

        if (collision.gameObject.tag == "GroundTag")

            this.isSound = true;

          audioSource.PlayOneShot(sound);


        //キューブが積み重なるとき、効果音を流す

        if (collision.gameObject.tag == "CubeTag")

            this.isSound = true;

            audioSource.PlayOneShot(sound);




    }
}
