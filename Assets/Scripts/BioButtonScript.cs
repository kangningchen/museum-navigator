using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BioButtonScript : MonoBehaviour, IPointerClickHandler
{
    public GameObject bioContent;
    public GameObject overviewContent;
    //private GameObject artistProfile;
    private bool bioContentRenderState;


    // Start is called before the first frame update
    void Start()
    {
        bioContent = GameObject.Find("BioContent");
        overviewContent = GameObject.Find("OverviewContent");
        //artistProfile = GameObject.Find("ArtistProfile");
        //if (!artistProfile.GetComponent<Animation>().isPlaying)
        //{
        //    this.GetComponent<Animation>().Play();
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("clicked");

        bioContentRenderState = bioContent.GetComponent<Renderer>().enabled;
       
        if (bioContentRenderState)
        {
            bioContent.GetComponent<Renderer>().enabled = false;

        }

        else
        {
            bioContent.GetComponent<Renderer>().enabled = true;
            overviewContent.GetComponent<Renderer>().enabled = false;

        }


    }
}
