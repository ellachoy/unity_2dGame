using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObject : MonoBehaviour
{
    public GameObject add;
    float timer = 0;
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
            GameObject newbed = Instantiate(add);
            newbed.transform.position = new Vector3(3, Random.Range(-5.0f, 5.0f), 0);
            timer = 0;
            Destroy(newbed, 10.0f);
        }
    }
}
