using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovement : MonoBehaviour
{
    public int speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;
        
    }
}
