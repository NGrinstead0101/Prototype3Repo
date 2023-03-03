using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBehaviour : MonoBehaviour
{
    public string goBack;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        //if left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            //go to scene
            SceneManager.LoadScene(goBack);
        }
    }
}
