using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBall : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3[] position;
    void Start()
    {
        int randomNumber= Random.Range(0,position.Length);
        transform.position = position [randomNumber];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
