using UnityEngine;
using System;

public class Factory : MonoBehaviour
{
    public GameObject prefab;
    public float spawnInterval = 1f;
    private float timer = 0f;

    public static event Action OnObjectSpawned;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }

    void SpawnObject()
    {
        Instantiate(prefab, Vector3.zero, Quaternion.identity);

        OnObjectSpawned?.Invoke();

        ObjectTracker.Instance.AddCount();
    }
}



