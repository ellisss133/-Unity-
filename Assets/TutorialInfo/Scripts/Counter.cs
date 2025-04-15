using UnityEngine;

public class Counter : MonoBehaviour
{
    private int count = 0;

    void OnEnable()
    {
        Factory.OnObjectSpawned += Increment;
    }

    void OnDisable()
    {
        Factory.OnObjectSpawned -= Increment;
    }

    void Increment()
    {
        count++;
        Debug.Log("Объектов создано: " + count);
    }
}
