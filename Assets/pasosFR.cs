using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasosFR : MonoBehaviour
{
    public AudioSource pasosfr;
    public float value;
    public float maxVol;

    public void Start()
    {
        AudioSource pasosMB = GetComponent<AudioSource>();
    }


    public void StopPasos()
    {
        pasosfr.Stop();
    }

    public void PlayPasos()
    {
        pasosfr.Play();
    }

    public void BajarPasos()
    {
        pasosfr.volume = Mathf.Lerp(pasosfr.volume, maxVol, value * Time.deltaTime);
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


