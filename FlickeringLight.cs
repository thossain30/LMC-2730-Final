using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    Light flickLight;
    public float minWaitTime;
    public float maxWaitTime;
    void Start()
    {
        flickLight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }
    IEnumerator Flashing()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            flickLight.enabled = !flickLight.enabled;
        }
    }
}
