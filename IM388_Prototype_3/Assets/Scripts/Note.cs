using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Note : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI noteText;

    /// <summary>
    /// Updates button text with evidence
    /// </summary>
    /// <param name="noteContents"></param>
    ///  //position of mouse
    Vector2 mousePosition;
    public bool follow;

    private void Start()
    {
        follow = false;
    }

    void Update()
    {
        //set mousePostition
        mousePosition = Input.mousePosition;
        if (follow == true)
        {
            transform.position = mousePosition;
        }
    }
    public void RevealNote(string noteContents)
    {
        noteText.text = noteContents;
    }

    public void toggleFollow()
    {
        follow = !follow;
    }
}
