using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float maxTime = 1;
    public float height;
    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        Vector3 pos = new Vector3(0, Random.Range(-height + (float)2.4, height + (float)2.4), 0);
        newPipe.transform.position = transform.position + pos;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            Vector3 pos = new Vector3(0, Random.Range(-height + (float)2.4, height + (float)2.4) , 0);
            newPipe.transform.position = transform.position + pos;
            Destroy(newPipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
