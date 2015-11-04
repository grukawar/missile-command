using UnityEngine;
using System.Collections;

public class Rocket : Missile {

	
	public float rocketSpeed = 10;
	public float rocketRange = 10;
	//private Turret turret;
	public bool fuckthisshit = true;

	private float rocketDistence;
		
	void Start () 
	{

	}
	

	void Update () 
	{
		transform.Translate (Vector3.up * Time.deltaTime * rocketSpeed);
		rocketDistence += Time.deltaTime * rocketSpeed;
		if (rocketDistence >= rocketRange)
						Explode ();
        



	}

	void OnCollisionEnter (Collision other)
	{
		if(other.gameObject.tag == "Enemy")
		{
            Parts.score += 1;
            Explode();
		}
	}

    
}
