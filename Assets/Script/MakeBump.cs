using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBump : MonoBehaviour
{

    public GameObject bump;
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
             GameObject newbump = Instantiate(bump);
             newbump.transform.position = new Vector3(2, Random.Range(-1.25f, 1.8f),0);
             timer = 0;
             Destroy(newbump,10.0f);
        }
       
    }
}
