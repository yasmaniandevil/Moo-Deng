using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallManagerTest : MonoBehaviour
{
    public List<GameObject> prefabsList = new List<GameObject>();

    private GameObject triPrefab = new GameObject();
    private GameObject circlePrefab = new GameObject();
    private GameObject hexPrefab = new GameObject();

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Instantiate(GameObject gameObject)
    {
        Instantiate(prefabsList[Random.Range(0, prefabsList.Count)]);
    }
    
    
}
