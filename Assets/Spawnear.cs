using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnear : MonoBehaviour
{
    public GameObject prefab = null;
    public GameObject coso;
    void Start()
    {
        instanciar();
    }

    public void instanciar ()
    {
        Vector3 spawnPosition = Random.insideUnitSphere * 5f;
        spawnPosition.x = 0;
        spawnPosition.y = 7;
        spawnPosition.z = 128;

        coso = Instantiate(prefab, spawnPosition, Quaternion.Euler(0, Random.value * 360, 0));
    }

    public void apagar()
    {
        Invoke("Destroy", 10f);
        //Destroy (prefab, 10f);////////////////noooo      
        //prefab.SetActive(false);
        Destroy(coso);
        Debug.Log("prefab");
    }
}
