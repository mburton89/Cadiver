using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysRotate : MonoBehaviour
{
    [SerializeField]
    private float _maxSpeed;
    private float _randomSpeed;
    private float _randomStartingZ;

    void Awake()
    {
        _randomSpeed = Random.Range(-_maxSpeed, _maxSpeed);
        _randomStartingZ = Random.Range(0, 360);
    }

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, _randomStartingZ);
    }

    void Update()
    {
        //float turnSpeed = _randomSpeed * Time.deltaTime;
        transform.Rotate(0, 0, _randomSpeed);
    }
}
