using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject enemy;
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
      
        if(other.gameObject.tag == "Player")
        {
            Debug.Log(" player lot vao cung attack cua enemy ---------------");
        //    player.gameObject.SetActive(false);
            Debug.Log("enemy chay toi player");
            enemy.transform.LookAt(player.transform.position);    
           enemy.transform.Translate(Vector3.forward * 10.0f * Time.deltaTime);
        //    enemy.transform.LookAt(other.transform.position);    
      //   transform.position=Vector3.MoveTowards(transform.position, player.transform.position, 20.0f* Time.deltaTime);    
    
     

        }

    }    
    // Update is called once per frame
    void Update()
    {
        
    }
}
