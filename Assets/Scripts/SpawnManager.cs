using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> objectsToSpawn;

    private float xBoundSpawnPos = 9f;
    private float ySpawnPos = 0.1f;
    private float zSpawnPos = 80f;

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }


    IEnumerator SpawnObjects()
    {
        while (!GameManager.Instance.gameOver) 
        {
            yield return new WaitForSeconds(3);
            
            int index = Random.Range(0, objectsToSpawn.Count);

            Vector3 position = new Vector3(Random.Range(-xBoundSpawnPos, xBoundSpawnPos), ySpawnPos, zSpawnPos);
            
            Instantiate(objectsToSpawn[index], position, objectsToSpawn[index].transform.rotation);
        }
    }
}
