using UnityEngine;

public class Donut : MonoBehaviour
{
    public int points = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            ScoreManager sm = FindObjectOfType<ScoreManager>();
            if (sm != null)
            {
                sm.AddScore(points);
            }

            Destroy(gameObject);
        }
    }
}