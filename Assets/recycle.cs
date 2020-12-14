using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recycle : MonoBehaviour
{
    private const float PLAYERDISTANCE_SPAWN_Level_Part = 200f;
    [SerializeField] private List<Transform> LevelPartList;
    [SerializeField] private Transform level_start;
    [SerializeField] private GameObject player;
    private Vector3 LastEndPosition;
    private void Awake()
    {
        LastEndPosition = level_start.Find("end position").position;
        int startingSpawnLevelParts = 5;
        for (int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
    }

    private void Update()
    {
        if (Vector3.Distance(player.transform.position, LastEndPosition) < PLAYERDISTANCE_SPAWN_Level_Part)
        {
            SpawnLevelPart();
        }
    }
    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = LevelPartList[Random.Range(0, LevelPartList.Count)];
        Transform lastlevelPartTransform = SpawnLevelPart(chosenLevelPart, LastEndPosition);
        LastEndPosition = lastlevelPartTransform.Find("end position").position;
    }
    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}