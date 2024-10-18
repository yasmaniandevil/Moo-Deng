using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerSitch : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector3(horizontalInput * speed, 0, 0);
    }


}
