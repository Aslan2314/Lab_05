using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    private float timeAlive = 0f;
    public float maxTimeAlive = 5f;
    // Update is called once per frame
    void Update()
    {
        if (timeAlive > maxTimeAlive)
        {
            Destroy(gameObject);
            Debug.Log(gameObject.name + " destroyed!");
        }
        timeAlive += Time.deltaTime;
    }
}

