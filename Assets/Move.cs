using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] GameObject objectPrefab; // Reference to the prefab you want to spawn
    private GameObject spawnedObject; // Reference to the spawned object

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Spawn the object at a random position
            SpawnObject();
        }
    }

    void SpawnObject()
    {
       
        // Generate a random position within the screen bounds
        Vector3 spawnPosition = new Vector3(
            Random.Range(-8f, 8f),
            Random.Range(-4.5f, 4.5f),
            0f
           
        );
        Destroy(gameObject);


        // Instantiate the object at the random position
        spawnedObject = Instantiate(objectPrefab, spawnPosition, Quaternion.Euler(Random.Range(-8f, 8f), Random.Range(-4.5f, 4.5f), 0f));
    }

    void DeleteObject()
    {
        // Destroy the spawned object
        Destroy(spawnedObject);
    }
}