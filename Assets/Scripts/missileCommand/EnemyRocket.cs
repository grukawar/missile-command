using UnityEngine;
using System.Collections;

public class EnemyRocket : Missile {

    public float rocketSpeed = 10;
    public float rocketRange = 10;
    public Transform target;
    public bool fuckthisshit = true;

    private float rocketDistence;

    void Start()
    {
        
    }


    void Update()
    {
       transform.LookAt(target);
       
        transform.Translate(Vector3.up * Time.deltaTime * rocketSpeed);
        rocketDistence += Time.deltaTime * rocketSpeed;
        if (rocketDistence >= rocketRange)
            Explode();

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Explode();
        }
        if(other.gameObject.tag == "Rocket")
        {
            Explode();
        }
    }


}
