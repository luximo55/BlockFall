using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallZone : MonoBehaviour
{
    public float SpawnRangeX = 5.0f;
    public float InstantiateRate = 1.0f;
    public float nextFire = 0.0f;
    public List<GameObject> PointPrefabs;
    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + InstantiateRate;
            InstantiatePoint();
        }
    }

    private void InstantiatePoint()
    {
        int randomPrefab = Random.Range(0, 100);
        float randomX = Random.Range(-SpawnRangeX, SpawnRangeX);
        Vector3 randomPosition = new Vector3(randomX, transform.position.y, transform.position.z);
        Debug.Log(randomPrefab);
        if(randomPrefab <= 30)
        {
            Instantiate(PointPrefabs[0], randomPosition, PointPrefabs[0].transform.rotation);
        }
        else if(randomPrefab <= 60 && randomPrefab > 30)
        {
            Instantiate(PointPrefabs[1], randomPosition, PointPrefabs[1].transform.rotation);
        }
        else if (randomPrefab <= 75 && randomPrefab > 60)
        {
            Instantiate(PointPrefabs[2], randomPosition, PointPrefabs[2].transform.rotation);
        }
        else if (randomPrefab <= 80 && randomPrefab > 75)
        {
            Instantiate(PointPrefabs[3], randomPosition, PointPrefabs[3].transform.rotation);
        }
        else if (randomPrefab <= 93 && randomPrefab > 80)
        {
            Instantiate(PointPrefabs[4], randomPosition, PointPrefabs[4].transform.rotation);
        }
        else if (randomPrefab <= 98 && randomPrefab > 93)
        {
            Instantiate(PointPrefabs[5], randomPosition, PointPrefabs[5].transform.rotation);
        }
        else if (randomPrefab <= 100 && randomPrefab > 98)
        {
            Instantiate(PointPrefabs[6], randomPosition, PointPrefabs[6].transform.rotation);
        }
    }
}
