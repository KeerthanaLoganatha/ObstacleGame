using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
     [SerializeField] float movingSpeed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movingSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movingSpeed; 
        transform.Translate(xValue,0,zValue);
    }
    
    
}
