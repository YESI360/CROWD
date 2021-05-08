using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BajarVol : MonoBehaviour
{
    public AudioSource amb;
    public float maxVol;
    public float value;

    void Start()
    {
        amb = GetComponent<AudioSource>();
    }

    public void StopPasos()
    {
        amb.Stop();
        //Debug.Log("stop");
    }

    public void PlayPasos()
    {
        amb.Play();
        //Debug.Log("play");
    }

    public void BajarPasos()
    {
        amb.volume = Mathf.Lerp(amb.volume, maxVol, value * Time.deltaTime);
        //Debug.Log("bajar");
    }

}
