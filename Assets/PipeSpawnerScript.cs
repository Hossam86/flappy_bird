using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawn_rate = 2;
    private float spawn_time = 0;
    public float pipe_offest = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawn_pipe();

    }

    // Update is called once per frame1                                                 
    void Update()
    {
        if (spawn_time < spawn_rate)
        {
            spawn_time += Time.deltaTime;
        }
        else
        {
            spawn_pipe();
            spawn_time = 0;
        }
    }

    private void spawn_pipe()
    {
        float heighest_point = transform.position.y + pipe_offest;
        float lowest_point = transform.position.y - pipe_offest;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest_point, heighest_point), transform.position.z), transform.rotation);
    }
}
