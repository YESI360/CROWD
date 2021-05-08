using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasosMG : MonoBehaviour
{
    public AudioSource pasosmg;
    public float value;
    public float maxVol;

    public void Start()
    {
        AudioSource pasosMB = GetComponent<AudioSource>();
    }


    public void StopPasos()
    {
        pasosmg.Stop();
    }

    public void PlayPasos()
    {
        pasosmg.Play();
    }

    public void BajarPasos()
    {
        pasosmg.volume = Mathf.Lerp(pasosmg.volume, maxVol, value * Time.deltaTime);
    }
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        BajarPasos();
    //        Debug.Log("baja");
    //    }

    //    if (Input.GetKeyDown("space"))
    //    {
    //        StopPasos();
    //        Debug.Log("stop");
    //    }
    //}
}


