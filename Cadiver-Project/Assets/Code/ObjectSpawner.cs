using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _treasurePrefab;
    [SerializeField]
    private GameObject _hazardPrefab;
    [SerializeField]
    private float _xMax;
    [SerializeField]
    private float _spawnSpeed;

    void Start()
    {
        StartCoroutine(spawnTreasure());
    }

    IEnumerator spawnTreasure()
    {
        SpawnObject(_treasurePrefab);
        yield return new WaitForSeconds(_spawnSpeed);
        StartCoroutine(spawnHazard());
    }

    IEnumerator spawnHazard()
    {
        SpawnObject(_hazardPrefab);
        yield return new WaitForSeconds(_spawnSpeed);
        StartCoroutine(spawnTreasure());
    }

    void SpawnObject(GameObject objectToSpawn)
    {
        var inWorldPosition = Camera.main.ScreenToWorldPoint(Vector3.zero);
        float randomX = Random.Range(-_xMax, _xMax);
        Vector3 spawnPosition = new Vector3(randomX, inWorldPosition.y - 1, 0);
        Instantiate(objectToSpawn, spawnPosition, transform.rotation);
    }
}
