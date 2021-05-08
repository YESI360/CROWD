using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasos : MonoBehaviour
{
    public AudioSource pasosmb;
    public float value;
    public float maxVol;

    public void Start()
    {
        AudioSource pasosMB = GetComponent<AudioSource>();
    }


    public void StopPasos()
    {
        pasosmb.Stop();
    }

    public void PlayPasos()
    {
        pasosmb.Play();
    }

    public void BajarPasos()
    {
        pasosmb.volume = Mathf.Lerp(pasosmb.volume, maxVol, value * Time.deltaTime);
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


