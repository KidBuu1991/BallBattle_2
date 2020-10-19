using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMoveToBall : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject ball;
    public GameObject player;
    public GameObject enemy;
    public Text winText;
    public GameObject MainMenu;
    public GameObject Attack;
    public Button PlayBtn;
    public bool isWin = false;
    private bool eatBall=false;
    public GameObject Fence_Defend;
    public Text TimerText;
    float currentTime =0.0f;
    float startingTime =15f;
    private bool isAttack= false;
    public float timeStart = 10;
    public bool isPass = false;
    
    public GameObject GameController;
    
    public float [] distance;
    public int indexPlayer;
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        
        TimerText.text = timeStart.ToString();
        currentTime = startingTime;
        
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            
            ball.transform.parent=player.transform;
            eatBall = true;
        }
        else
        {

            eatBall = false;
        }
        if(other.gameObject.tag == "Fence_Defend")
        {
        //    Debug.Log(" Goal ---------------");
        //    player.gameObject.SetActive(false);
            winText.text= "You Win ";
            isWin= true;
            Time.timeScale = 0;
          //  MainMenu.SetActive(true);
           // PlayBtn.GetComponentInChildren<Text>().text = "Play again";
        } else
        {

            isWin = false; 
        }
      /* if(other.gameObject.tag =="Attack")
        {
            Debug.Log(" 2222222222222222Player lot vao vung attack cua enemy");
         
            Attack.transform.LookAt(other.transform.position);    
            Attack.transform.position=Vector3.MoveTowards(Attack.transform.position, other.transform.position, speed* Time.deltaTime);
            isAttack= true;
           

        }else
        {

            isAttack= false;
        }
        */
        if(other.gameObject.tag =="Enemy")
        {
       //     Debug.Log(" 222222222222222222Player bi enemy an");
            isPass = true;
        //    isWin = false;
            winText.text= "Player chuyen banh "; 
            
          //  Time.timeScale = 0; 

        }
        else
        {
            isPass=false;
        }
          
        
        
    }
  
   
//abstract[i].getcoponent<script>.

    // Update is called once per frame
    void Update()
    {
      /* currentTime-= 1* Time.deltaTime;
       TimerText.text= currentTime.ToString ("0"); 
       TimerText.color= Color.red;
       if(currentTime<=0)
       {
           currentTime = 0; 
           
       }*/
        transform.LookAt(ball.transform.position);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (eatBall)
        {        
       //    Debug.Log("ball move to goal aaaaaaaaaaaaa");    
           player.transform.LookAt(Fence_Defend.transform.position);    
           player.transform.Translate(Vector3.forward * speed * Time.deltaTime);
           eatBall = false;
        }
       /* if(isAttack==true)
        {

            Attack.transform.LookAt(player.transform.position);    
            Attack.transform.position=Vector3.MoveTowards(Attack.transform.position, player.transform.position, speed* Time.deltaTime);
            isAttack=false;
            

        }*/
        if(currentTime ==0 && isWin ==false )
        {

            winText.text= "You Lose "; 
            Time.timeScale = 0;           
        }
        

//        EnemyAttackPlayer();

        if(isPass == true)
        {
           Debug.Log("_____________________chuyen banh");
          /* float distanceMin= Vector3.Distance(player.transform.position,
            GameController.GetComponent<ClickSpawnPlayer>().playerList[0].transform.position);
          //    Debug.Log ("khoang cach nho nhat "+distanceMin);
              
            for (int i=0;i<GameController.GetComponent<ClickSpawnPlayer>().playerCount;i++)
            {
                float currDistance= Vector3.Distance(player.transform.position,
                GameController.GetComponent<ClickSpawnPlayer>().playerList[i].transform.position);
                
                if(distanceMin > currDistance )
                {
                    distanceMin = currDistance;
                    indexPlayer = i;
                }                
                Debug.Log ("khoang cach nho nhat "+distanceMin);
                Debug.Log ("vi tri player co khoang cach nho nhat"+indexPlayer);   
                
            }
      //     ball.transform.LookAt(GameController.GetComponent<ClickSpawnPlayer>().playerList[indexPlayer].transform.position);
        //    ball.transform.Translate (Vector3.forward * speed * Time.deltaTime);
            ball.transform.position=Vector3.MoveTowards(ball.transform.position,GameController.GetComponent<ClickSpawnPlayer>().playerList[indexPlayer].transform.position
            
            , speed* Time.deltaTime);
         
            */
                
                
            

        }
        

        
        
    }
}
