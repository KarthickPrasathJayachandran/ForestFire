using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ProBuilder.AutoUnwrapSettings;

public class pondcollide : MonoBehaviour
{
    public gunrefill refill;
    public bool isInsidePond = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if (isInsidePond)
        {
            if (Input.GetButton("Fire1")) //button X to Refill the water level in gun
            {
                //Debug.Log("Trigger");
                refill.waterlevel = refill.waterlevel + 10;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
    if (other.gameObject.tag == "Player")
    {
        Debug.Log("in pond");
        isInsidePond = true;
        
        
    }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("in pond");
            isInsidePond = false;


        }
    }
}
