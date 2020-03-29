using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FirstButton : MonoBehaviour
{	

    public GameObject earLeft_mesh;
    public GameObject earRight_mesh; 
    // Start is called before the first frame update
    void Start()
    {
      earLeft_mesh = GameObject.Find("earLeft_mesh");
      earRight_mesh = GameObject.Find("earRight_mesh");
      //Debug.Log("Hello: " + earLeft_mesh.name);
      //Debug.Log("Hello: " + earRight_mesh.name);
    }

    // Update is called once per frame
    //void Update()
    //{        
    //}
     	

     public void changeMaterial(Material inputmaterial){	
	earLeft_mesh.GetComponent<SkinnedMeshRenderer>().material = inputmaterial;
	earRight_mesh.GetComponent<SkinnedMeshRenderer>().material = inputmaterial;
     }	

}
