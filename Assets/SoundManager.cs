
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public GameObject SoundsGO;
    public BajarVol ambScript;
    
    public pasosMB MaleBScript;
    public pasosMG MaleGScript;
    public pasosFP FemalePScript;
    public pasosFR FemaleRScript;

    public AudioSource instrucciones;
    public float delay = 10;

    void Start()
    {
        instrucciones.PlayDelayed(delay);
        ambScript = SoundsGO.GetComponent<BajarVol>();
    }

}
