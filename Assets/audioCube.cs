using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioCube : MonoBehaviour
{
    public AudioSource cube;
    public void StopPasos()
    {
        cube.Stop();
    }

    public void PlayPasos()
    {
        cube.Play();
    }

    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        StopPasos();
    //        Debug.Log("paro");
    //    }

    //    if (Input.GetKeyDown("space"))
    //    {
    //        PlayPasos();
    //        Debug.Log("playAgain");
    //    }
}
