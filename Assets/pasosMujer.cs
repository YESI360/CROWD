using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasosMujer : MonoBehaviour
{
    public AudioSource pasosFP;

    public void StopPasos()
    {
        pasosFP.Stop();
    }

    public void PlayPasos()
    {
        pasosFP.Play();
    }


}
