using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;


public class spawn : MonoBehaviour
{
    public GameObject nagent;
    public GameObject goalObject;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnAgent", 2);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject na = (GameObject)Instantiate(nagent, this.transform.position, Quaternion.identity);
        na.GetComponent<walkTo>().goal = goalObject.transform;
        Invoke("spawnAgent", Random.Range(2, 5));
    }
}
