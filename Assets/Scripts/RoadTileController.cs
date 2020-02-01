using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadTileController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject badRoad = transform.GetChild(0).gameObject;
        GameObject goodRoad = transform.GetChild(1).gameObject;
        goodRoad.SetActive(true);
        badRoad.SetActive(false);
    }
}
