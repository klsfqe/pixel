using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    private void Start()
    {
        for (int i = 0; i <15; i++)
            Instantiate(enemy, GetRandomPosition(), Quaternion.identity);
    }
    public Vector3 GetRandomPosition()
    {
        float radius = 3f;
        Vector3 playerPosition = transform.position;

        float a = playerPosition.x;
        float b = playerPosition.y;

        float x = Random.Range(-radius + a, radius + a);
        float y_b = Mathf.Sqrt(Mathf.Pow(radius, 2) - Mathf.Pow(x - a, 2));
        y_b *= Random.Range(0, 2) == 0 ? -1 : 1;
        float y = y_b + b;

        Vector2 randomPosition = new Vector2(x, y);

        return randomPosition;
    }
}