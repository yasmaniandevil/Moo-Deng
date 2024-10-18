using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bounce : MonoBehaviour
{
    //private Transform transformy;

    public float zAxis;
    // Start is called before the first frame update
    void Start()
    {
        //transformy = GetComponent<Transform>();

        //vector3 to, float duration, bool snapping
        //moves target position to a given value
        //If TRUE the tween will smoothly snap all values to integers.
        //transformy.DOMove(new Vector3(2, 0, 0), 1f, true);
        //Debug.Log("Moved");

        gameObject.transform.DORotate(new Vector3(0f, 0f, zAxis), 2f, RotateMode.LocalAxisAdd).SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
