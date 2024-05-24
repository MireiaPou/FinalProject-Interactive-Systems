using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMovement : MonoBehaviour
{
    public GameObject player1; 
    public GameObject player2; 
    public GameObject box1; 
    public GameObject box2; 

    public string tagbox1;
    public string tagbox2;

    public bool istrigger1;
    public bool istrigger2;  

    public float DestroyDelay; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (istrigger1){
            transform.position = player1.transform.position;
        }
        
        if (istrigger2){
            transform.position = player2.transform.position;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        print("Enter!!!");
        if (other.CompareTag(tagbox1)) 
        {
            print("Box");
            istrigger1 = false; 
            transform.position = box1.transform.position;
            Destroy(gameObject, DestroyDelay); 
        }
        if (other.CompareTag(tagbox2)) 
        {
            print("Box");
            istrigger2 = false; 
            transform.position = box2.transform.position;
            Destroy(gameObject, DestroyDelay); 
        }
    }


}
