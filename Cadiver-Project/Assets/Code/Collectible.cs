using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectible : MonoBehaviour
{
    public AudioClip collectSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        SoundManager.Instance.PlaySound(collectSound);
        if (collision.GetComponent<Cadiver>())
        {
            GetCollected(collision.GetComponent<Cadiver>());
        }
    }

    public abstract void GetCollected(Cadiver cadiver);
}