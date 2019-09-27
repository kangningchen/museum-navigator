using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUserTrace : MonoBehaviour
{
    public GameObject breadCrumb;
    private Vector3 currentCamPosition;
    private Vector3 lastCrumbPosition = new Vector3(0, 0, 0);
    private Quaternion crumbRotation = Quaternion.Euler(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<GetUserTrace>().enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {

        PlaceBreadCrumb();

    }

    private void PlaceBreadCrumb()
    {
    
        //var crumbPosition = Camera.current.ViewportToWorldPoint(new Vector3(Screen.width/2, Screen.height/2));
        currentCamPosition = new Vector3(Camera.current.transform.position.x, Camera.current.transform.position.y, Camera.current.transform.position.z);
        //Debug.Log(currentCamPosition);
        float dist = Vector3.Distance(lastCrumbPosition, currentCamPosition);
        if (dist > 0.3)
        {
            Instantiate(breadCrumb, currentCamPosition, crumbRotation);
            lastCrumbPosition = currentCamPosition;
        }

        //crumbPosition.z = Camera.current.transform.position.z;


    }

    public void GetTrace()
    {
        var activeStatus = GetComponent<GetUserTrace>().enabled;
 
        if (activeStatus == true)
        {
            GetComponent<GetUserTrace>().enabled = false;
        }
        else
        {
            GetComponent<GetUserTrace>().enabled = true;
        }
    }


}
