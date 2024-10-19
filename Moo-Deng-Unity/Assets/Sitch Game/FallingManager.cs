using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingManager : MonoBehaviour
{


    

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
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
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
            int randomObstacles = Random.Range(4, 7);
            //how many objects it spawns at a time if i = 1 it will spawn one of each obj
            //with randomObstacles it will spawn anywhere from 1-10 obstacles of each shape
            for (int i = 0; i < randomObstacles; i++)
            {
                Debug.Log("Random Obstacles: " + randomObstacles);
                Vector3 randomPosTri = new Vector3(Random.Range(8, -8), Random.Range(5, 15), 0);
                Vector3 randomPosCir = new Vector3(Random.Range(8, -8), Random.Range(5, 15), 0);
                Vector3 randomPosHex = new Vector3(Random.Range(8, -8), Random.Range(5, 15), 0);

                Instantiate(triPrefab, randomPosTri, Quaternion.identity);
                Instantiate(circlePrefab, randomPosHex, Quaternion.identity);
                Instantiate(hexPrefab, randomPosCir, Quaternion.identity);
            }

            yield return new WaitForSeconds(timeBetweenWaves);
            Debug.Log("SpawnTime" + timeBetweenWaves);
            currentWave++;
            Debug.Log("Current Wave: " + currentWave);
        }
        

    }
}
