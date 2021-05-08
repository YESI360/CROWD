using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apagar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void destruir()
    {
        Destroy(this.gameObject);
        //DestroyImmediate(this.gameObject, true);//no!
    }
}
