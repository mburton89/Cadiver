using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cadiver : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float horizontalSpeed = 8f;
    public float verticalSpeed = -1f;
    float horizontalMove = 0f;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * horizontalSpeed;
        _rigidbody2D.AddForce(new Vector2(horizontalMove, verticalSpeed));
    }

    public void AddDownwardForce(float amountOfForceToAdd)
    {
        verticalSpeed = verticalSpeed - amountOfForceToAdd;
    }
}
