using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recommend : MonoBehaviour
{   
    public GameObject content;

     
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void recommend(GameObject incontent)
    {	  
	  content = incontent; 	
	  var x = Random.Range(1, 9);   		
	  var y = Random.Range(1, 9);  
	  var originTransform = content.transform;
          var colors = originTransform.GetChild( x ).GetComponent<Button> ().colors; 
          colors.normalColor = Color.blue;
          originTransform.GetChild( x ).GetComponent<Button> ().colors = colors;  	
          originTransform.GetChild( y ).GetComponent<Button> ().colors = colors;   		
    } 
}
