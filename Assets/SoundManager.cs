using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;
using System;
using UnityEngine.Events;

public class SoundManager : MonoBehaviour
{
    public GameObject SoundsGO;
    public BajarVol ambScript;
    
    public GameObject SpawnMBGO;//blue MB
    public pasosMB MaleBScript;

    public GameObject SpawnMGO;//green MG
    public pasosMG MaleGScript;

    public GameObject SpawnFPGO;//pink FP
    public pasosFP FemalePScript;

    public GameObject SpawnFRGO;//red FR
    public pasosFR FemaleRScript;

    public AudioSource instrucciones;
    public float delay = 15;

    void Start()
    {

        instrucciones.PlayDelayed(delay);

        ambScript = SoundsGO.GetComponent<BajarVol>();

        MaleBScript = SpawnMBGO.GetComponent<pasosMB>();

        MaleGScript = SpawnMGO.GetComponent<pasosMG>();

        FemalePScript = SpawnFPGO.GetComponent<pasosFP>();

        FemaleRScript = SpawnFRGO.GetComponent<pasosFR>();
    }

    void Update()
    {

        /*
        if (Input.GetKey("down"))
        {
            ambScript.StopPasos();
            FemalePScript.StopPasos();
            FemaleRScript.StopPasos();
            MaleBScript.StopPasos();
            MaleGScript.StopPasos();
            //Debug.Log("paro");
        }

        if (Input.GetKeyDown(KeyCode.Space)) //if (Input.GetMouseButtonDown(0))        
        {          
            //ambScript.BajarPasos();
            //FemalePScript.BajarPasos();
            //FemaleRScript.BajarPasos();
            //MaleBScript.BajarPasos();
            //MaleGScript.BajarPasos();
            //Debug.Log("bajar");
        }

        if (Input.GetKey("up"))
        {
            ambScript.PlayPasos();
            FemalePScript.PlayPasos();
            FemaleRScript.PlayPasos();
            MaleBScript.PlayPasos();
            MaleGScript.PlayPasos();
            //Debug.Log("playAgain");
        }
        */

    }


}
