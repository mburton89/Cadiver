using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Cadiver>())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
