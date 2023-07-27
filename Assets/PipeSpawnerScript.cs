using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawn_rate = 2;
    private float spawn_time = 0;
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
        Instantiate(pipe, transform.position, transform.rotation);
    }
}
