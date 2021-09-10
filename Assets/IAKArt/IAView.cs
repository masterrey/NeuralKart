using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAView : MonoBehaviour
{

    //public float view01, view02, view03, view04, view05;
    public Neurons view01, view02, view03, view04, view05;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position+Vector3.up * 0.5f, transform.forward, out hit,10))
        {
            view01.state = hit.distance/10;
            Debug.DrawLine(transform.position, hit.point, Color.red);
        }
        else
        {
            view01.state = 1;
        }
        
        if (Physics.Raycast(transform.position + transform.up*0.5f, transform.forward + transform.right, out hit, 100))
        {
            view02.state = hit.distance/10;
            Debug.DrawLine(transform.position, hit.point, Color.blue);
        }
        else
        {
            view02.state = 1;
        }

        if (Physics.Raycast(transform.position + transform.up * 0.5f, transform.forward - transform.right, out hit, 100))
        {
            view03.state = hit.distance/10;
            Debug.DrawLine(transform.position, hit.point, Color.green);
        }
        else
        {
            view03.state = 1;
        }
        if (Physics.Raycast(transform.position + transform.up * 0.5f,  transform.right, out hit, 100))
        {
            //print(hit.collider.gameObject.name);
            view04.state = hit.distance/10;
            Debug.DrawLine(transform.position + transform.up * 0.5f, hit.point, Color.cyan);
        }
        else
        {
            view04.state = 1;
        }

        if (Physics.Raycast(transform.position + transform.up * 0.5f, -transform.right, out hit, 100))
        {
            view05.state = hit.distance/10;
            Debug.DrawLine(transform.position + transform.up * 0.5f, hit.point, Color.magenta);
        }
        else
        {
            view05.state = 1;
        }


    }
}
