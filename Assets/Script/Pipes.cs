using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public List<GameObject> pipes = new List<GameObject>();
    private List<GameObject> spawnedPipes = new List<GameObject>(); // Keep track of spawned pipes

    void Start()
    {
        StartCoroutine(RandomTimeSpawning());
    }

    void Update()
    {
        MovePipes();
    }

    IEnumerator RandomTimeSpawning()
    {
        while (true)
        {
            float randomTime = Random.Range(2f, 5f);
            yield return new WaitForSeconds(randomTime);

            if (pipes.Count > 0)
            {
                int randomIndex = Random.Range(0, pipes.Count);
                SpawnPipe(pipes[randomIndex]);
            }
        }
    }
    GameObject lastPipe;
    void SpawnPipe(GameObject p)
    {
        Vector3 spawnPosition = new Vector3(70, Random.Range(-6f, 5.6f), 0f);
        GameObject lil_Pipe = Instantiate(p, spawnPosition, Quaternion.identity);
        lastPipe = lil_Pipe;
        spawnedPipes.Add(lil_Pipe);
    }

    void MovePipes()
    {
        float randomSpeed = Random.Range(4f, 7f);

        for (int i = 0; i < spawnedPipes.Count; i++)
        {
            if (spawnedPipes[i] != null)
            {
                spawnedPipes[i].transform.Translate(Vector3.left * randomSpeed * Time.deltaTime);
            }
        }
    }

}


