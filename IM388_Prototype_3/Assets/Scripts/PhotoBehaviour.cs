using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotoBehaviour : MonoBehaviour
{
    //scene to go to
    public string goTo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //when mouse is over photo
    private void OnMouseOver()
    {
        //if left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        { 
            //go to scene
            SceneManager.LoadScene(goTo);
        }
    }
}
