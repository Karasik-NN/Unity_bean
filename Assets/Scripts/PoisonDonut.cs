using UnityEngine;

public class PoisonDonut : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            HealthManager hm = FindObjectOfType<HealthManager>();
            if (hm != null)
            {
                hm.TakeDamage();
            }

            Destroy(gameObject);
        }
    }
}