using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OverviewButtonScript : MonoBehaviour, IPointerClickHandler
{
    public GameObject bioContent;
    public GameObject overviewContent;
    private bool overviewContentRenderState; 

    public void OnPointerClick(PointerEventData eventData)
    {
       overviewContentRenderState = overviewContent.GetComponent<Renderer>().enabled;

        if (overviewContentRenderState)
        {
            overviewContent.GetComponent<Renderer>().enabled = false;

        }

        else
        {
            overviewContent.GetComponent<Renderer>().enabled = true;
            bioContent.GetComponent<Renderer>().enabled = false;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        bioContent = GameObject.Find("BioContent");
        overviewContent = GameObject.Find("OverviewContent");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
