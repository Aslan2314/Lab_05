using UnityEngine;

public class Respawn : MonoBehaviour
{
    void Update()
    {
        if (respawnable && inactive) {
            if (respawnTime > maxRespawnTime)
            {
                gameObject.SetActive(true);
                inactive = false;
            }
            respawnTime += Time.deltaTime;
        }
    }
}
