using UnityEngine;
using System.Collections;

public class MouseScript : MonoBehaviour
{
    public GameObject Target;
    void Update()
    {
        RaycastHit hit;
        Ray position = new Ray(transform.position, Vector3.forward);
        if (Input.GetButtonDown("Fire1"))
        {
            if(Physics.Raycast(position, out hit, 0))
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray))
               Instantiate(Target, transform.position, transform.rotation);
           // Debug.Log("llllllaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        }
    }
}