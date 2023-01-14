using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] int speed = -1;
  
    void Update()
    {
        transform.position +=  new Vector3(speed, 0, 0) * Time.deltaTime;
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
