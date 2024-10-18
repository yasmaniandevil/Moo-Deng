using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FallingObjects : MonoBehaviour
{
    private Transform transformy;
   

    // Start is called before the first frame update
    void Start()
    {
        transformy = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //transformy.DOMove(new Vector3(-5, 0, 0), 1f, true);

        float randomSpeed = Random.Range(.5f, 2f);
        transformy.position = transform.position + new Vector3(0, -5 * randomSpeed * Time.deltaTime, 0);
        Debug.Log(randomSpeed);

        
    }
}
