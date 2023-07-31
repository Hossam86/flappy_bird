using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTriggerScript : MonoBehaviour
{

    public Logic_Script logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Script>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.add_score();
    }
}
