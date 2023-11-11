using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;
   private void OnCollisionEnter(Collision other) 
   {
    if(other.gameObject.tag != "Hits")
    {
        hits++;
        Debug.Log("Number of times you hit the wall is:" + hits);
    }
    
   }
}
