using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    int whatToSpawn;
    public float Radius = -1;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 6);
            Debug.Log(whatToSpawn);

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(prefab5, transform.position, Quaternion.identity);
                    break;
            }

            nextSpawn = Time.time + spawnRate;
            if (Input.GetKeyDown(KeyCode.Space)) SpawnObjectAtRandom();
        }
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space)) SpawnObjectAtRandom();
    //}

    void SpawnObjectAtRandom()
    {
        Vector3 randomPos = Random.insideUnitCircle * Radius;
        Instantiate(prefab1, randomPos, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, Radius);
    }
}
