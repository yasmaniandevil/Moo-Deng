using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class PlayerSitch : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 5;

    public TextMeshProUGUI scoreDisplayText;
    private int lives = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        scoreDisplayText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector3(horizontalInput * speed, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("collided");
            lives--;
            Debug.Log("Lives: " + lives);
            scoreDisplayText.text = "Lives: " + lives;
        }
        

    }


}
