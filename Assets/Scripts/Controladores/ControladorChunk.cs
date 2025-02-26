using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorChunk : MonoBehaviour
{
    [SerializeField] List<Chunk> chunks = new List<Chunk>();
    [SerializeField] Transform lastChunk;
    [SerializeField] float velocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < chunks.Count; i++)
        {
            chunks[i].transform.Translate(Vector3.left * velocity * Time.deltaTime, Space.World);

            if (chunks[i].transform.position.x <= -10)
            {
                chunks[i].transform.position = lastChunk.position + (Vector3.right * 7);
                lastChunk = chunks[i].transform;

                chunks[i].GenerarObstaculos();
            }
        }
    }
}
