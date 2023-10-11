using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillar : MonoBehaviour
{
    private spawner p_spawner;
    // Start is called before the first frame update
    void Start()
    {
        p_spawner = GameObject.Find("spawner").GetComponent<spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if( transform.position .x >70){
            Destroy(gameObject);
        }
        transform.position += Vector3.right *p_spawner.pillarspeed* Time.deltaTime;
    }


}
