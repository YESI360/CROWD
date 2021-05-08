using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundMan : MonoBehaviour
{
    public GameObject spawnGO;
    public audioCube spawnScript;
    public pasos spawnScript2;

    void Start()
    {
        spawnGO = GameObject.Find("spawn");
        spawnScript = spawnGO.GetComponent<audioCube>();
        spawnScript2 = spawnGO.GetComponent<pasos>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spawnScript.StopPasos();
            spawnScript2.StopPasos();
            Debug.Log("paro");

        }

        if (Input.GetKeyDown("space"))
        {
            spawnScript.PlayPasos();
            spawnScript2.PlayPasos();
            Debug.Log("playAgain");
        }
    }
}
