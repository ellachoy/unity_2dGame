using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBed : MonoBehaviour
{
    public GameObject bed;
    float timer= 0;
    public float timeDiff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newbed = Instantiate(bed);
            newbed.transform.position = new Vector3(1, Random.Range(-1.5f, 2.0f),0);
            timer = 0;
            Destroy(newbed, 10.0f);
        }
    }
}
