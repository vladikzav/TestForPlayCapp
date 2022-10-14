using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{

    public TMP_InputField iSpawnTime;
    public TMP_InputField iSpeed;
    public TMP_InputField iDistance;
    public GameObject cube;
    public float spawnTime = 20;
    public float speed = 20;
    public float distance = 14;
    private float timer;

    void Start()
    {
        timer = spawnTime;
    }

    
    void Update()
    {
        Timer();
        StateChecker();
    }

    void Timer()
    {
        if (timer <= 0)
        {
            InstantiateNewCube();
            timer = spawnTime;
            timer -= Time.deltaTime;
        }
        else if(timer >= spawnTime)
        {
            timer = spawnTime;
            timer -= Time.deltaTime;
        }
        timer -= Time.deltaTime;
    }

    void StateChecker()
    {
        if (spawnTime <= 0)
        {
            spawnTime = 2;
        }
        if (speed <= 0)
        {
            speed = 2;
        }
        if (distance <= 0)
        {
            distance = 10;
        }
    }

    void InstantiateNewCube()
    {
        GameObject c = Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
        c.GetComponent<Cube>().speed = speed;
        c.GetComponent<Cube>().distance = distance;

    }
    
    public void SetSpawnTime()
    {
        spawnTime = TryGetFloat(iSpawnTime.text);
    }

    public void SetSpeed()
    {
        speed = TryGetFloat(iSpeed.text);
    }

    public void SetDistance()
    {
        distance = TryGetFloat(iDistance.text);
    }

    public static float TryGetFloat(string str)
    {
        float res;
        float.TryParse(str, out res);
        return res;
    }
}
