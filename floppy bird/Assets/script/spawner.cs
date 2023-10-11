using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] pillar;

    public float Timer;

    public float Spawn_until_nexttime;

    public bool canSpawn;

    public float pillarspeed;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        canSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn == true){
            if(Timer < Spawn_until_nexttime){
                Timer += Time.deltaTime;
            }
        
        else{
            Spawn();
            Timer=0;
        }
        }
    }

    void Spawn(){
        int random_number = Random.Range(0,7);
             Instantiate(pillar[random_number],transform.position,Quaternion.identity);
    }
}
