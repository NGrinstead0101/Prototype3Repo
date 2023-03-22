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
    public int boundUp;
    public int boundDown;
    public int boundLeft;
    public int boundRight;

    private void Start()
    {
        follow = false;
    }

    void Update()
    {
        //set mousePostition. changed to screen to world point input
        mousePosition = Input.mousePosition;
        if (follow == true)
        {
            transform.position = mousePosition;
        }
        if (transform.position.x >= boundRight)
        {
            transform.position = new Vector2(boundRight, transform.position.y);
        }
        if (transform.position.x <= boundLeft)
        {
            transform.position = new Vector2(boundLeft, transform.position.y);
        }
        if (transform.position.y >= boundUp)
        {
            transform.position = new Vector2(transform.position.x, boundUp);
        }
        if (transform.position.y <= boundDown)
        {
            transform.position = new Vector2(transform.position.x, boundDown);
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
