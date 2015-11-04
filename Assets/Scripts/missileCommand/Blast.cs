using UnityEngine;
using System.Collections;

public class Blast : MonoBehaviour
{
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        
            Vector3 scale = transform.localScale;
            scale.y = scale.y * 1.1f;
            scale.x = scale.x * 1.1f;
            scale.z = scale.z * 1.1f;
            transform.localScale = scale; 
        
        
    }
}
