using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bounce : MonoBehaviour
{
    //private Transform transformy;
    public List<GameObject> cubes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //transformy = GetComponent<Transform>();

        //vector3 to, float duration, bool snapping
        //moves target position to a given value
        //If TRUE the tween will smoothly snap all values to integers.
        //transformy.DOMove(new Vector3(2, 0, 0), 1f, true);
        //Debug.Log("Moved");

        
    }

    // Update is called once per frame
    void Update()
    {
        RotateCubeAroundAxis();
    }

    void RotateCubeAroundAxis()
    {
        //(new Vector3(45, 0f, 0f), 1f, RotateMode.LocalAxisAdd).SetLoops(-1);
        cubes[0].transform.DORotate(new Vector3(45f, 0f, 0f), 1f, RotateMode.LocalAxisAdd).SetLoops(-1);
        cubes[1].transform.DORotate(new Vector3(0f, 45f, 0), 1f, RotateMode.LocalAxisAdd).SetLoops(-1);
        cubes[2].transform.DORotate(new Vector3(0f, 0f, 45f), 1f, RotateMode.LocalAxisAdd).SetLoops(-1);
    }
}
