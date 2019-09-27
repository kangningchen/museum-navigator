using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectModel : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Cube()
    {
        sphere.transform.localScale = new Vector3(0, 0, 0);
        if (cube.transform.localScale == new Vector3((float)20.0, (float)20.0, (float)20.0))
        {
            cube.transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            cube.transform.localScale = new Vector3((float)20.0, (float)20.0, (float)20.0);
        }
        //cube.GetComponent<UnityEngine.XR.iOS.UnityARHitTestExample>().enabled = true;
        //sphere.GetComponent<UnityEngine.XR.iOS.UnityARHitTestExample>().enabled = false;
        //cylinder.GetComponent<UnityEngine.XR.iOS.UnityARHitTestExample>().enabled = false;

    }

    public void Sphere()
    {

        cube.transform.localScale = new Vector3(0, 0, 0);
        if (sphere.transform.localScale == new Vector3((float)0.1, (float)0.1, (float)0.1))
        {
            sphere.transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            sphere.transform.localScale = new Vector3((float)0.1, (float)0.1, (float)0.1);
        }
        //cube.GetComponent<Renderer>().enabled = false;
        //sphere.GetComponent<Renderer>().enabled = true;
        //cylinder.GetComponent<Renderer>().enabled = false;
        //cube.GetComponent<UnityEngine.XR.iOS.UnityARHitTestExample>().enabled = false;
        //sphere.GetComponent<UnityEngine.XR.iOS.UnityARHitTestExample>().enabled = true;
        //cylinder.GetComponent<UnityEngine.XR.iOS.UnityARHitTestExample>().enabled = false;

    }


}
