using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gunrefill : MonoBehaviour
{
    public float waterlevel = 100;     //  Player refilling variable
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = waterlevel.ToString();
    }
   
    
}
