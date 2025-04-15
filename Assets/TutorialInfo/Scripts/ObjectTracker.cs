using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    public int objectCount { get; private set; }

    public static ObjectTracker Instance { get; private set; }

    void Awake()
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

    public void AddCount()
    {
        objectCount++;
        Debug.Log("Total Objects Spawned: " + objectCount);
    }
}
