﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMachine : MonoBehaviour
{
    public GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawner ()
    {
        yield return new WaitForSeconds(1);
        Vector3 vt = pipe.transform.position;
        vt.y = Random.Range(-2.5f, 2.5f);
        Instantiate(pipe, vt, Quaternion.identity);
        StartCoroutine(Spawner());
    }

}
