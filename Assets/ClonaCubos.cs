using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonaCubos : MonoBehaviour
{
    public GameObject cuboPreFab;
    void Start()
    {
        Instantiate(cuboPreFab);

    }

   
    void Update()
    {
       
    }

    public void ClonarCubos()
    {
        Instantiate(cuboPreFab);
    }
}


