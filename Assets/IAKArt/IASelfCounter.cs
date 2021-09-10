using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IASelfCounter : MonoBehaviour
{
    public int waypassed = 0;
    GameObject lasttrack;
    public DNAGenerator dna;
    private void OnTriggerEnter(Collider other)
    {

        if (lasttrack != other.gameObject) { 
            if (other.gameObject.layer == 11)
            {
                lasttrack = other.gameObject;
                waypassed++;
            }
        }else{
            waypassed = 0;
        }
    }
}
