using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Note : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI noteText;

    public void RevealNote(string noteContents)
    {
        noteText.text = noteContents;
    }
}
