using UnityEngine;
using UnityEngine.SceneManagement;

public class Instrucciones : MonoBehaviour
{
    [SerializeField] int CantidadDeVidosIntruccion_1 = 100;
    [SerializeField] int CantidadDeVidosIntruccion_3 = 20;
    [SerializeField] SpawnerGeneral spawnScript;
    [SerializeField] MicControlC mic;
    [SerializeField] float minLoudnessDetection = 0.02f;
    [SerializeField] AudioSource audioS;
    [SerializeField] AudioClip[] clips;
    [SerializeField] LevelManager levelManager;

    int instructions = 0;

    private void Start()
    {
        audioS.clip = clips[instructions];
        audioS.PlayDelayed(10);
    }
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    instructions = spawnScript.DestroyEntities(3);
        //}

        if (audioS.isPlaying)
            return;
        
        if (mic.loudness > minLoudnessDetection)
        {
            if (instructions == 0)
            {
                print("Instruccion completada");
                instructions = spawnScript.DestroyEntities(CantidadDeVidosIntruccion_1);
                audioS.clip = clips[instructions];
                audioS.PlayDelayed(3);
                return;
            }

            if (instructions == 1)
            {
                print("Instruccion completada");
                instructions = spawnScript.ChangeAnimation();
                audioS.clip = clips[instructions];
                audioS.PlayDelayed(3);
                return;
            }

            if (instructions == 2)
            {
                print("Instruccion completada");
                spawnScript.DestroyEntities(CantidadDeVidosIntruccion_3);
                audioS.clip = clips[instructions];
                audioS.PlayDelayed(10);
                instructions = 3;
                return;
            }
        }

        if (instructions == 3)
        {
            levelManager.LoadNextLevel();
        }
    }
}
