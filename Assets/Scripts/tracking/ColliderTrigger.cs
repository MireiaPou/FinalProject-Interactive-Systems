using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    public string tagplayer1;
    public string tagplayer2;
    public GameObject fossil; 

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag(tagplayer1)) 
        {
            fossil.GetComponent<ObjectsMovement>().istrigger1 = true; 
        }
        if (other.CompareTag(tagplayer2)) 
        {
            fossil.GetComponent<ObjectsMovement>().istrigger2 = true; 
        }
    }
}
