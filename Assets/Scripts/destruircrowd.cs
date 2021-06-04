using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruircrowd : MonoBehaviour
{//USAR PARA TESTEAR SIN MIC
    public SpawnerMB spawnScriptMB;
    public SpawnerFR spawnScriptFR;
    public SpawnerFP spawnScriptFP;
    public SpawnerMG spawnScriptMG;

    public BajarVol ambScript;
    public pasosFP FemalePScript;
    public pasosFR FemaleRScript;
    public pasosMB MaleBScript;
    public pasosMG MaleGScript;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            spawnScriptMB.apagar(4);
            spawnScriptFR.apagar4(4);
            spawnScriptFP.apagar3(4);
            spawnScriptMG.apagar2(4);

            ambScript.BajarPasos();

            FemalePScript.BajarPasos();
            FemaleRScript.BajarPasos();
            MaleBScript.BajarPasos();
            MaleGScript.BajarPasos();
        }
        
    }




}
