using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingManager : MonoBehaviour
{


    //public List<GameObject> prefabs = new List <GameObject>();

    public GameObject triPrefab;
    public GameObject circlePrefab;
    public GameObject hexPrefab;

    // Start is called before the first frame update
    void Start()
    {
        DropObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DropObjects()
    {
        Vector3 randomPosTri = new Vector3(Random.Range(8, -8), Random.Range(5, 15), 0);
        Vector3 randomPosCir = new Vector3(Random.Range(8, -8), Random.Range(5, 15), 0);
        Vector3 randomPosHex = new Vector3(Random.Range(8, -8), Random.Range(5, 15), 0);
        /*foreach(GameObject prefab in prefabs)
        {
            GameObject newPrefab = Instantiate(prefab, randomPos, Quaternion.identity);
        }*/


        Instantiate(triPrefab, randomPosTri, Quaternion.identity);
        Instantiate(circlePrefab, randomPosHex, Quaternion.identity);
        Instantiate(hexPrefab, randomPosCir, Quaternion.identity);

        //Instantiate(, new Vector3(7, 5), Quaternion.identity);

        /*for(int i = 0; i < 10; i++)
        {

        }*/
    }
}
