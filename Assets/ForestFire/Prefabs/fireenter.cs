using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// When the player enter the  fire cell - the script will detects the player is near.
public class fireenter : MonoBehaviour
{
    public ForestFireCell forestfire;
    private wateremit emit;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //IEnumerator shoot()  //Player shoot it takes 2 seconds for turnoff fire
    //{
    //    yield return new WaitForSeconds (2f);
    //    this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")       //To check Player is near
        {
            if (forestfire.cellState.ToString() == "Alight")
            {
               
                if(other.gameObject.GetComponent<wateremit>().isshoot)
                {
                    Debug.Log("fire");
                    this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
                }
                //emit = other.GetComponent<wateremit>();
                //if (emit.isshoot)
                //{

                //    Debug.Log("fire");
                //    //   forestfire.ResetCell();
                //    // forestfire._fireVisualEffect.enabled = false;
                //    StartCoroutine(shoot());
                //}
            }
        }
    }
}
