using UnityEngine;

public class BounceOffEdge : MonoBehaviour
{
    private Rigidbody2D _rigidBody2D;
    private Vector3 _prevPosition;
    
    [SerializeField]
    private float bounceDampener;

    void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        print(Camera.main.WorldToScreenPoint(transform.position));
    }

    void LateUpdate()
    {
        Vector3 tmpPos = Camera.main.WorldToScreenPoint(transform.position);

        if (tmpPos.x < 0)
        {
            transform.position = new Vector3(_prevPosition.x, transform.position.y, 0);
            _rigidBody2D.velocity = new Vector2(-_rigidBody2D.velocity.x / bounceDampener, _rigidBody2D.velocity.y);
        }
        else if (tmpPos.x > Screen.width)
        {
            transform.position = new Vector3(_prevPosition.x, transform.position.y, 0);
            _rigidBody2D.velocity = new Vector2(-_rigidBody2D.velocity.x / bounceDampener, _rigidBody2D.velocity.y);
        }

        _prevPosition = transform.position;
    }
}
