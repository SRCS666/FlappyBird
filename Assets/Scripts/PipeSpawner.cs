using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipe;

    [SerializeField] private float maxTime;
    [SerializeField] private float heightRange;
    [SerializeField] private float destroyTime;

    private float timer;

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0f, Random.Range(-heightRange, heightRange));
        GameObject newPipe = Instantiate(pipe, spawnPos, Quaternion.identity);

        Destroy(newPipe, destroyTime);
    }
}
