using UnityEngine;

public class PistolBehavior : MonoBehaviour
{
    public GameObject laserTemplate;
    public Transform spawnPoint;
    public int clipSize = 10;
    private int shotsRemaining = 10;

    public void ShootLaser()
    {
        if (shotsRemaining > 0) {
            GameObject clone = Instantiate(laserTemplate, spawnPoint.position, spawnPoint.rotation);
            Rigidbody m_Rigidbody = clone.GetComponent<Rigidbody>();
            m_Rigidbody.AddForce(spawnPoint.forward * 200);
            shotsRemaining -= 1;
        }
    }

    public void reload() {
        shotsRemaining = clipSize;
    }
}
