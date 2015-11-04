using UnityEngine;
using System.Collections;

public class health : MonoBehaviour 
{

	public float integrity = 10;
	public GameObject destroyed;
	public int integrityValue = 1;
	public static bool dead;

	void Start()
	{
		dead = false;
	}

	
}
