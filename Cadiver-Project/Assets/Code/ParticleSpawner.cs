using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject particlePrefab;

    private float _randomness = 0.25f;
    private float _x;
    private float _y;
    private Vector3 _spawnPosition;
    
    void Update()
    {
        _x = Random.Range(transform.position.x - _randomness, transform.position.x + _randomness);
        _y = Random.Range(transform.position.y, transform.position.y + (_randomness * 3));
        _spawnPosition = new Vector3(_x, _y, 0);
        Instantiate(particlePrefab, _spawnPosition, transform.rotation);
    }
}
