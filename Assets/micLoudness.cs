using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class micLoudness : MonoBehaviour
{
    public MicControlC micControllerGO;    
    public GameObject controller;
    float averagedLoudness = 0.0f;
    public float amp = 1.0f;

    public Vector2 inhaleTriggerRange;
    public float exhaleTriggerThreshold;

    float oldvalue = 0.0f;
    float newvalue = 0.0f;
    bool isComingBackFromPip = false;

    public BajarVol ambScript;
    public pasosFP FemalePScript;
    public pasosFR FemaleRScript;
    public pasosMB MaleBScript;
    public pasosMG MaleGScript;

    public SpawnerMB spawnScript;
    public SpawnerMG spawnScript2;
    public SpawnerFP spawnScript3;
    public SpawnerFR spawnScript4;

    void Update()
    {
        newvalue = micControllerGO.loudness;

        averagedLoudness = (newvalue + oldvalue) / 2;

        isComingBackFromPip = !isComingBackFromPip && averagedLoudness < inhaleTriggerRange.x;

        bool isInhaling = newvalue >= inhaleTriggerRange.x && newvalue <= inhaleTriggerRange.y;
        bool isExhaling = averagedLoudness >= exhaleTriggerThreshold;

        //bool shouldPlayPop = isInhaling && !piiiip.isPlaying && !isComingBackFromPip;
        //bool shouldPlayPip = isExhaling && !pop.isPlaying;

        if (isInhaling )//&& !pop.isPlaying)  //(averagedLoudness < 0.14f)
        {
            //Debug.Log("pop");
            transform.localScale = new Vector3(2f, 2f, 2f);
            //pop.Play();
            //ambScript.StopPasos();
            //FemalePScript.StopPasos();

        }

        else if (isExhaling)// && !piiiip.isPlaying)//&& averagedLoudness <= 0.60f )  //(averagedLoudness > 0.30f)
        {
            //Debug.Log("piiiip");
            transform.localScale = new Vector3(2f + averagedLoudness * amp, 2f + averagedLoudness * amp, 2f + averagedLoudness * amp);
            //piiiip.Play();

            ambScript.BajarPasos();

            FemalePScript.BajarPasos();
            FemaleRScript.BajarPasos();
            MaleBScript.BajarPasos();
            MaleGScript.BajarPasos();
            //Debug.Log("bajar");

            spawnScript.apagar(5);
            spawnScript2.apagar2(5);
            spawnScript3.apagar3(5);
            spawnScript4.apagar4(5);
        
            isComingBackFromPip = false;
        }

        oldvalue = newvalue;
    }

    public void sensitivity(float sense)
    {
        amp = sense;
    }

}
