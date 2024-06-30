using System.Collections.Generic;
using UnityEngine;

public class SceneTransitionManager : MonoBehaviour
{
    public static SceneTransitionManager Instance { get; private set; }

    private Dictionary<int, Dictionary<string, Vector3>> sceneSpawnPositions = new Dictionary<int, Dictionary<string, Vector3>>();
    private string defaultSpawnPointName = "default";
    private Vector3 defaultSpawnPosition = Vector3.zero; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetSpawnPosition(int sceneIndex, string spawnPointName, Vector3 position)
    {
        if (!sceneSpawnPositions.ContainsKey(sceneIndex))
        {
            sceneSpawnPositions[sceneIndex] = new Dictionary<string, Vector3>();
        }
        sceneSpawnPositions[sceneIndex][spawnPointName] = position;
    }

    public Vector3 GetSpawnPosition(int sceneIndex, string spawnPointName)
    {
        if (sceneSpawnPositions.TryGetValue(sceneIndex, out Dictionary<string, Vector3> spawnPoints))
        {
            if (spawnPoints.TryGetValue(spawnPointName, out Vector3 position))
            {
                return position;
            }
        }
        return defaultSpawnPosition;
    }
}
