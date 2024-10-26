using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FallingObjects : MonoBehaviour
{
    private bool isMoving = true;
    

    // Start is called before the first frame update
    void Start()
    {
       
        
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
            //GetComponent<Rigidbody2D>().isKinematic = true;
            //store currentPos relative to plate
            //Vector3 localPos = transform.position - collision.transform.position;
            //parent it to get its transform
            //transform.SetParent(collision.transform);
            //maintain objpos relative to plate
            //transform.localPosition = localPos;
            //Debug.Log("follow plate");
        }
    }

    void MoveFunction()
    {
        if(isMoving == true)
        {
            float randomSpeed = Random.Range(.5f, 2f);
            transform.position = transform.position + new Vector3(0, -5 * randomSpeed * Time.deltaTime, 0);


            if (this.gameObject.transform.position.y <= -5)
            {
                Destroy(this.gameObject);
            }
        }
        
    }
}
