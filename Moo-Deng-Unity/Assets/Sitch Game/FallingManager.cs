using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingManager : MonoBehaviour
{


    //public List<GameObject> prefabs = new List <GameObject>();

    public GameObject triPrefab;
    public GameObject circlePrefab;
    public GameObject hexPrefab;

    public int totalWaves = 3;
    public float timeBetweenSpawn = 4f;
    public float timeBetweenWaves = 4f;

    // Start is called before the first frame update
    void Start()
    {
        //DropObjects();
        StartCoroutine(Drop());
       
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


        for(int i = 0; i < 3; i++)
        {
            Instantiate(triPrefab, randomPosTri, Quaternion.identity);
            Instantiate(circlePrefab, randomPosHex, Quaternion.identity);
            Instantiate(hexPrefab, randomPosCir, Quaternion.identity);
        }     

    }

    IEnumerator Drop()
    {
        int currentWave = 0;

        while(currentWave < totalWaves)
        {
            //how many objects it spawns at a time if i = 1 it will spawn each object once
            for (int i = 0; i < 1; i++)
            {
                Vector3 randomPosTri = new Vector3(Random.Range(8, -8), Random.Range(5, 15), 0);
                Vector3 randomPosCir = new Vector3(Random.Range(8, -8), Random.Range(5, 15), 0);
                Vector3 randomPosHex = new Vector3(Random.Range(8, -8), Random.Range(5, 15), 0);

                Instantiate(triPrefab, randomPosTri, Quaternion.identity);
                Instantiate(circlePrefab, randomPosHex, Quaternion.identity);
                Instantiate(hexPrefab, randomPosCir, Quaternion.identity);
            }

            yield return new WaitForSeconds(timeBetweenSpawn);
            Debug.Log("SpawnTime" + timeBetweenSpawn);
            currentWave++;
        }

        yield return new WaitForSeconds(timeBetweenWaves);
        Debug.Log("WaveTime" + timeBetweenWaves);
        

    }
}
