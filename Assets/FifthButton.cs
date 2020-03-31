using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifthButton : MonoBehaviour
{
    public GameObject earLeft_mesh;
    public GameObject earRight_mesh; 
    public GameObject FaceTexture;
    public GameObject fur_mesh;
    public GameObject nose_mesh; 
    // Start is called before the first frame update
    void Start()
    {
      earLeft_mesh = GameObject.Find("earLeft_mesh");
      earRight_mesh = GameObject.Find("earRight_mesh");
      FaceTexture = GameObject.Find("FaceTexture");
      fur_mesh = GameObject.Find("fur_mesh");
      nose_mesh = GameObject.Find("nose_mesh");

    }

    // Update is called once per frame
    //void Update()
    //{        
    //}
     	

     public void changeMaterial(Material inputmaterial){

	FaceTexture.GetComponent<MeshRenderer>().material = inputmaterial;
	earLeft_mesh.SetActive(false);
	earRight_mesh.SetActive(false);
	fur_mesh.SetActive(false);
        nose_mesh.SetActive(false);

     }	
}
