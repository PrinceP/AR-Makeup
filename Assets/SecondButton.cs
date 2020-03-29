using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondButton : MonoBehaviour
{
    public GameObject earLeft_mesh;
    public GameObject earRight_mesh; 
    public GameObject FaceTexture; 
    
    // Start is called before the first frame update
    void Start()
    {
      earLeft_mesh = GameObject.Find("earLeft_mesh");
      earRight_mesh = GameObject.Find("earRight_mesh");
      FaceTexture = GameObject.Find("FaceTexture");
      
      //Debug.Log("Hello: " + earLeft_mesh.name);
      //Debug.Log("Hello: " + earRight_mesh.name);
    }

    // Update is called once per frame
    //void Update()
    //{        
    //}
     	

     public void changeMaterial(Material inputmaterial){

	FaceTexture.GetComponent<MeshRenderer>().material = inputmaterial;
	earLeft_mesh.SetActive(false);
	earRight_mesh.SetActive(false);

     }	
}
