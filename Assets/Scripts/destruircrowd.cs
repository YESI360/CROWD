using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruircrowd : MonoBehaviour
{
    public SpawnerMB spawnScript;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spawnScript.apagar(4);

        }
        
    }




}
