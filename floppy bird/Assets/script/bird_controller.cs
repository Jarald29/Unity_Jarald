using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class bird_cntroller : MonoBehaviour
{
    Rigidbody rb;

    public float jumpspeed;

    public bool isGameover;

    public spawner pillar_spawner;

    public int Points;

    public TMP_Text point_text;

    public GameObject gameoverscreen;

    public TMP_Text final_points;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
       isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) & isGameover == false){
            rb.AddForce(Vector3.up*jumpspeed, ForceMode.Impulse);
        }
        if(rb.velocity.y <0){
            Physics.gravity = new Vector3(0,-30,0);
        }
        else{
             Physics.gravity = new Vector3(0,-10,0);
        }
        if(isGameover == true){
            gameoverscreen.SetActive (true);
            final_points.text = "final points :" + Points ;
        }
        else{
            gameoverscreen.SetActive(false);
        }
    }
        void OnCollisionEnter(Collision collision_object){
        if ( collision_object.gameObject.tag == "pillars" || collision_object.gameObject.tag == "ground"){
              isGameover = true; 
              pillar_spawner.canSpawn = false;
              pillar_spawner.pillarspeed = 0; 
        }
    }
    void OnTriggerEnter( Collider coll_obj){
        if( coll_obj.gameObject.name == "triger"){
        Points += 1;
        point_text.text = "points :" +  Points ;
    }}

    public void replay(){
        SceneManager.LoadScene(0);
    } 
}
