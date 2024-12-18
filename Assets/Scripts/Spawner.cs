using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance { get; private set; }

    public GameObject trash;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // public void createTrash(GameObject trash)
    // {
    //     GameObject spawnPoint = new GameObject();
    //     Instantiate(trash, spawnerPoint.transform);
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}
