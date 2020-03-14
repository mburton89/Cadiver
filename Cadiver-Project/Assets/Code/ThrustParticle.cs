using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustParticle : MonoBehaviour
{
    private float _fadeSpeed;
    private float _scale;
    private Vector3 _spawnPosition;
    [SerializeField] private SpriteRenderer _sprite;

    private void Awake()
    {
        _fadeSpeed = Random.Range(0.1f, 0.8f);
        _scale = Random.Range(0.25f, 1f);
    }

    private void Start()
    {
        transform.localScale = new Vector3(_scale, _scale, 0);
    }

    void Update()
    {
        if (_sprite.color.a > 0)
        {
            float newAlpha = _sprite.color.a - _fadeSpeed;
            _sprite.color = new Color(_sprite.color.r, _sprite.color.g, _sprite.color.b, newAlpha);
            transform.Translate((Vector3.up * 5) * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
