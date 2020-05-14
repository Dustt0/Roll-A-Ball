using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackManager : MonoBehaviour
{
    public GameObject[] trackPrefabs;

    private Transform playerTransform;
    private float spawnZ = -7.8f;
    private float trackLength = 30.0f;
    private float safeZone = 30.0f;
    private int amtTilesOnScreen = 7;
    private int lastPrefabIndex = 0;

    private List<GameObject> activetracks;
    void Start()
    {
        activetracks = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for(int i=0; i<amtTilesOnScreen; i++)
        {
            if (i < 2)
                SpawnTiles(0);
            else
                SpawnTiles();
        }
    }

    
    void Update()
    {
        if (playerTransform.position.z - safeZone > (spawnZ - amtTilesOnScreen * trackLength))
        {
            SpawnTiles();
            DeleteTrack();

        }
    }

    private void SpawnTiles(int prefabIndex = -1)
    {
        GameObject go;
        if (prefabIndex == -1)
            go = Instantiate(trackPrefabs[RandomPrefabIndex()]) as GameObject;
        else
            go = Instantiate(trackPrefabs[prefabIndex]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += trackLength;
        activetracks.Add(go);

    }

    private void DeleteTrack()
    {
        Destroy(activetracks[0]);
        activetracks.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (trackPrefabs.Length <= 1)
            return 0;

        int randomIndex = lastPrefabIndex;
        while(randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, trackPrefabs.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
