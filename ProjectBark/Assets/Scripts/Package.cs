using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bark")
        {
            gameObject.transform.SetParent(other.gameObject.transform);
        }

        if(other.gameObject.tag == "Goal")
        {
            this.gameObject.transform.parent = null;
        }
    }
}
