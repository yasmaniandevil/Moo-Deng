using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallManagerTest : MonoBehaviour
{
    public List<GameObject> prefabsList = new List<GameObject>();
    

    public int maxGroupsPerWave = 3;
    public float timeBtwnGroups = 3f;
    public int totalWaves = 3;
    public float timeBtwnWaves = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstantiatePrefabs());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Restarted");
        }

        
    }



    IEnumerator InstantiatePrefabs()
    {
        int currentWave = 0;
        while(currentWave < totalWaves)
        {
            for (int groups = 0; groups < maxGroupsPerWave; groups++)
            {
                int randomObstacles = Random.Range(4, 7);

                for (int i = 0; i < randomObstacles; i++)
                {
                    Vector3 randomPos = new Vector3(Random.Range(8, -8), Random.Range(5, 15), 0);
                    int randomPrefab;
                    randomPrefab = Random.Range(0, prefabsList.Count);
                    Instantiate(prefabsList[randomPrefab], randomPos, Quaternion.identity);

                }

                yield return new WaitForSeconds(timeBtwnGroups);
                //Debug.Log("Next Group" + groups);
            }

            yield return new WaitForSeconds(timeBtwnWaves);
            currentWave++;
            //Debug.Log("Current Wave No: " + currentWave);


        }


    }

   




}
