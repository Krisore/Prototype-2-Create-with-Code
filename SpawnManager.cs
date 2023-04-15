
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; 
    
    #region SpawnField Properties

    private const float SpawnRangeX = 18f;
    private const float SpawnPositionZ = 20f;
    private const float SpawnDelay = 2.5f;
    private const float SpawnInterval = 1.5f;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;

    #endregion // <- Spawn field
    
    // Start is called before the first frame update
    private void Start() 
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), time: SpawnDelay, repeatRate: SpawnInterval);
    }
    // Update is called once per frame
    private void SpawnRandomAnimal()
    {
        var animalIndex = Random.Range(0, animalPrefabs.Length);
        var spawnPosition = new Vector3(x: Random.Range(-SpawnRangeX, SpawnRangeX), y: 0, z: SpawnPositionZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
        SpawnLeftAnimal();
        SpawnRightAnimal();
    }

    private void SpawnLeftAnimal()
    {
        var animalIndex = Random.Range(0, animalPrefabs.Length);
        var spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        var rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    private void SpawnRightAnimal()
    {
        var animalIndex = Random.Range(0, animalPrefabs.Length);
        var spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        var rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
