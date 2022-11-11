using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class wateremit : MonoBehaviour
{
    public ParticleSystem waterspray;    //particle effect for spray water from gun
    public gunrefill reduce;
    public bool isshoot= false;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       // waterspray.Play();
        if (Input.GetButton("Fire2")) // Button A in Joystick to emits water or it shoots water
        {
            isshoot = true;
            if (reduce.waterlevel > 0)
            {
           // Debug.Log("spraying1111");
                shoot();
            }
        }
        else
        {
            
            if (isshoot)
            {
               isshoot =false;
            }
            else
            { waterspray.Stop(); }
            //
        }
    }
    public void shoot()
    {
        
        waterspray.Play();  
        reduce.waterlevel = reduce.waterlevel - 5;     //it will reduce waterlevel
    }
}
