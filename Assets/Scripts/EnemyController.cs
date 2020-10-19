using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyController : MonoBehaviour
{
    public float speed = 1.0f;
    public float distanceAttach = 5.0f;
    public float distanceFind = 20.0f;
    public GameObject player;    
    public GameObject myEnemy;
    public List<GameObject> EnemyList;
    public int EnemyCount;
    public GameObject currentEnemy;
    private Text loseText;

    public Transform PlayerTarget;

    // Start is called before the first frame update
    void Start()
    {
        EnemyList = new List<GameObject>();
        EnemyCount = 0;
    
    }
    void OnTriggerEnter(Collider other)
    {
        
      /*  if(other.gameObject.tag == "Attack")
        {

            Debug.Log ("Player vao vung bi tan cong ");
        }*/
   //     if (other.gameObject.tag == "Player")
       // {
      //      Debug.Log("enemy ăn player ");
         
            
   //     }
        

       
    }
    // Update is called once per frame
    void Update()
    {
        if (EnemyCount == 0)
        {
            currentEnemy = null;
        }
      /*  if(Vector3.Distance(myEnemy.position, PlayerTarget.position)<= distanceFind && Vector3.Distance(myEnemy.position,PlayerTarget.position)>=distanceAttach)
        {
     //       Debug.Log("enemy di chuyen toi player");
            myEnemy.LookAt(PlayerTarget);
            myEnemy.position= Vector3.MoveTowards (myEnemy.position, PlayerTarget.position, speed*Time.deltaTime);
            
        } */
   //     else if (Vector3.Distance(myEnemy.position, PlayerTarget.position)<= distanceAttach && Vector3.Distance(myEnemy.position, PlayerTarget.position)> 0)
     //   {

      //      Debug.Log("enemy tan cong  toi player");
            // enemy tan cong player

       // }
     //   else
       // {

         //   Debug.Log("enemy khong di chuyen toi player ");
     //   }
        
    }
}
