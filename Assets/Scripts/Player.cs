using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject tiro;
        
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
          Vector3 pos = this.transform.position;
          Instantiate(tiro,pos,Quaternion.Euler(0,0,0));
        }
    }
}
