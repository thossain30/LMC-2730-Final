using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private int totalNum = 15;
    private int numCollected;
    GameObject door = GameObject.FindWithTag("Exit");
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TP")
        {
            numCollected++;
            Destroy(other.gameObject);
            if (numCollected == totalNum)
            {
                door.SetActive(true);
            }
            else
            {
                door.SetActive(false);
            }
        }
    }
}
