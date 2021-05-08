using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasosFP : MonoBehaviour
{
    public AudioSource pasosfp;
    public float value;
    public float maxVol;

    public void Start()
    {
        AudioSource pasosMB = GetComponent<AudioSource>();
    }


    public void StopPasos()
    {
        pasosfp.Stop();
    }

    public void PlayPasos()
    {
        pasosfp.Play();
    }

    public void BajarPasos()
    {
        pasosfp.volume = Mathf.Lerp(pasosfp.volume, maxVol, value * Time.deltaTime);
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


