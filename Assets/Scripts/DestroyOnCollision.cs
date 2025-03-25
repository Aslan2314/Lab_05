using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public bool destroyWithAnyObject = false;
    public string collisionTag = "";
    public int health = 1;
    private bool inactive = false;
    public bool respawnable = false;
    public float maxRespawnTime = 5f;
    private float respawnTime = 0f;


    void OnCollisionEnter(Collision collision)
    {
        if (destroyWithAnyObject || collision.gameObject.CompareTag(collisionTag))
        {
            health -= 1;
            if (health <= 0) {
                if (respawnable) {
                    gameObject.SetActive(false);
                    inactive = true;
                } else {
                    Destroy(gameObject);
                }
            }
        }
    }
}
