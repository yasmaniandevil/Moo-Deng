using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FallingObjects : MonoBehaviour
{
    private Transform transformy;

    private bool isMoving = true;

    // Start is called before the first frame update
    void Start()
    {
        transformy = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {

        MoveFunction();
       
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isMoving = false;
            Debug.Log("turned false");
        }
    }

    void MoveFunction()
    {
        if(isMoving == true)
        {
            float randomSpeed = Random.Range(.5f, 2f);
            transformy.position = transform.position + new Vector3(0, -5 * randomSpeed * Time.deltaTime, 0);


            if (this.gameObject.transform.position.y <= -5)
            {
                Destroy(this.gameObject);
            }
        }
        
    }
}
