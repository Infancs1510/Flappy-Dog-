using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 2;
    
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime); 

        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}