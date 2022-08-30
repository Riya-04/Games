using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour
{
    public GameObject obstacle;

    void Start()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);  

    }

    
    void Update()
    {
        
    }
}
