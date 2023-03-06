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
    public void RevealNote(string noteContents)
    {
        noteText.text = noteContents;
    }
}
