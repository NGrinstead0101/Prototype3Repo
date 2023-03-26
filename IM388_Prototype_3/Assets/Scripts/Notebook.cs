using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{
    static bool gotInitialPos = false;

    [SerializeField] GameObject notebookUI;
    bool notebookActive = false;
    bool canClick = true;

    GameObject[] noteObjects;
    Note[] noteScriptList;

    [SerializeField] EvidenceTracker evidenceTracker;

    /// <summary>
    /// Finds Note objects and initializes variables
    /// </summary>
    private void Awake()
    {
        noteObjects = GameObject.FindGameObjectsWithTag("Note");

        if (!gotInitialPos)
        {
            gotInitialPos = true;
            for (int i = 0; i < noteObjects.Length; ++i)
            {
                FoundEvidence.notePositions[i] = noteObjects[i].transform.position;
            }
        }

        for (int i = 0; i < noteObjects.Length; ++i)
        {
            noteObjects[i].transform.position = FoundEvidence.notePositions[i];
            noteObjects[i].SetActive(false);
        }

        noteScriptList = new Note[noteObjects.Length];

        for (int i = 0; i < noteScriptList.Length; ++i)
        {
            noteScriptList[i] = noteObjects[i].GetComponent<Note>();
        }
    }

    /// <summary>
    /// Toggles interface when right clicking
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) && canClick)
        {
            canClick = false;
            StartCoroutine(PreventDoubleClick());
            ToggleNotebook();
        }
    }

    /// <summary>
    /// Toggles the notebook UI and reveals notes for evidence the player has found
    /// </summary>
    private void ToggleNotebook()
    {
        notebookActive = !notebookActive;
        notebookUI.SetActive(notebookActive);

        if (notebookActive)
        {
            for (int i = 0; i < noteObjects.Length && i < FoundEvidence.foundList.Length; ++i)
            {
                if (FoundEvidence.foundList[i] == true)
                {
                    noteObjects[i].SetActive(true);
                    noteScriptList[i].RevealNote(evidenceTracker.evidenceList[i].evidenceName);
                }
            }
        }
        else
        {
            for (int i = 0; i < noteObjects.Length; ++i)
            {
                FoundEvidence.notePositions[i] = noteObjects[i].transform.position;
                noteObjects[i].SetActive(false);
            }
        }
    }

    /// <summary>
    /// Prevents double inputs when toggling the notebook
    /// </summary>
    /// <returns></returns>
    IEnumerator PreventDoubleClick()
    {
        yield return new WaitForSeconds(0.25f);

        canClick = true;

        StopAllCoroutines();
    }
}
