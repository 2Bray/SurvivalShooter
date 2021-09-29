using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public GameOverManager gameOverManager;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Enemy" && !other.collider.isTrigger)
        {
            float enemyDistance = Vector3.Distance(transform.position, other.transform.position);
            gameOverManager.ShowWarning(enemyDistance);
        }
    }
}