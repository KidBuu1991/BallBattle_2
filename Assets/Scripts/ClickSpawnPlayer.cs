using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickSpawnPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    
    //public GameObject pickUp;
    public GameObject _PlayerPrefab;
    public GameObject _EnemyPrefab;
    public GameObject currentPlayer;
    public GameObject currentEnemy;
    public int playerCount;
    public GameObject playerTarget;
    public int enemyCount;
    public float speed;
    Vector3 pos;
    public List<GameObject> playerList;
    public List<GameObject> enemyList;
    public Camera mainCamera;
    public bool addForce = false;
    public bool Isplayer;
    public bool IsEnemy;
    public float currentTimeSpawn;
    public float startingTimeSpawn =0;
    
    public Text TimerText;
    public float currentTime=0.0f;
    float startingTime =140f;
    public float timeStart = 10f;
    

    public GameObject Player;
    void Start()
    {
        _EnemyPrefab.SetActive(false); // giai quyet duoc player tao cung luc voi ball
        _PlayerPrefab.SetActive(false);
        currentTimeSpawn = startingTimeSpawn;
        TimerText.text = timeStart.ToString();
        currentTime = startingTime;
    }

    // Update is called once per frame
  
    void MovePlayer( Vector3 movePosition)
    {  
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);
        transform.Translate(Vector3.forward*Time.deltaTime*10.0f);

    }
    public void GetTimeMatch()
    {
        currentTime-= 1* Time.deltaTime;
        TimerText.text= currentTime.ToString ("0"); 
        TimerText.color= Color.red;
        if(currentTime<=0)
        {
            currentTime = 0; 
            
        }

    }
    public void GetTimeEnegrybar()
    {
        currentTimeSpawn+= 2* Time.deltaTime;
        if(currentTimeSpawn==2)
        {


        }
        
    }

    void Update()
    {
        // click mouse
        GetTimeMatch();
        currentTimeSpawn+= 1* Time.deltaTime;
   //     Debug.Log("aaaaaaaaaaa"+currentTimeSpawn);
        
       // if (currentTimeSpawn>=6)
        {
            if(Input.GetMouseButtonDown(0))
            {
                if (playerCount == 0)
                {
                currentPlayer = null;
                }
                if (enemyCount == 0)
                {
                currentEnemy = null;
                }
                Vector3 mouseScreenPosition = Input.mousePosition;
                Ray ray = Camera.main.ScreenPointToRay(mouseScreenPosition);
                
                if( Physics.Raycast(ray, out RaycastHit hitInfo))
                {
                        float spawn_x = hitInfo.point.x;
                        float spawn_y = hitInfo.point.y;
                        float spawn_z = hitInfo.point.z;
                        if(spawn_z > 0)
                        {
                      //      Debug.Log ("spawn enemyyyyyyyyyyyyyyyy");
                            enemyCount +=1;
                            GameObject newEnemy = Instantiate(_EnemyPrefab, new Vector3(spawn_x, spawn_y + 0.5f, spawn_z), Quaternion.identity);
                            newEnemy.SetActive(true);    
                            enemyList.Add(newEnemy);
                            if(currentEnemy == null)
                            {

                                currentEnemy = enemyList[0];
                            }
                        
                        }
                        else if(spawn_z < 0)
                        {
                        //    Debug.Log ("spawn playerrrrrrrrrrrrrrrrrrrrrrrrrr");
                            playerCount +=1;
                            GameObject newPlayer = Instantiate(_PlayerPrefab, new Vector3(spawn_x, spawn_y + 0.5f, spawn_z), Quaternion.identity);
                            newPlayer.SetActive(true);
                            playerList.Add(newPlayer);
                            if(currentPlayer == null)
                            {
                                currentPlayer = playerList[0];
                            }
                        


                        }
                    
                
                    
                    
                    
                }
                
                    
            }
        }    
                //if(Vector3.Distance(myEnemy.position, PlayerTarget.position)<= distanceFind && Vector3.Distance(myEnemy.position,PlayerTarget.position)>=distanceAttach)
  /*         for (int i=0;i< playerCount;i++)
            {
                Vector3.Distance(playerList[i].transform.position, playerList[i+1].transform.position)
                {
                   Debug.Log ("khboang cach giua 2 player ");
                } 
            }
*/

                
            
        

    }
}
