using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAudio : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        //地面とキューブが接触した時に音を鳴らす
        if (other.gameObject.tag == "ground")
        {
            GetComponent<AudioSource>().Play();
        }

        //キューブとキューブが接触した時に音を鳴らす
        if (other.gameObject.tag == "block")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}