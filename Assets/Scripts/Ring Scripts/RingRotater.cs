using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingRotater : MonoBehaviour
{
    int _rotationSpeed;

    void RingRotate()
    {
        _rotationSpeed = Random.Range(1, 50);
        transform.Rotate(0f, 0f, _rotationSpeed * Time.deltaTime);
        
    }
    private void Update()
    {
       
        RingRotate();
        Debug.Log(_rotationSpeed);
    }

  
}
