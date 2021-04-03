/*
 * Chris Smith
 * SuspectAI
 * Assignment 9
 * A script that controls the suspect's AI state based on player input.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuspectAI : MonoBehaviour
{
    public SuspectState relaxed { get; set; }
    public SuspectState nervous { get; set; }
    public SuspectState defensive { get; set; }
    public SuspectState angered { get; set; }

    public int stress;
    public SuspectState current { get; set; }
    public Text text;
    public Text tutorial;

    // Start is called before the first frame update
    void Start()
    {
        relaxed = new Relaxed(this);
        nervous = new Nervous(this);
        defensive = new Defensive(this);
        angered = new Angered(this);

        stress = 0;
        current = relaxed;
    }

    // Update is called once per frame
    void Update()
    {
        tutorial.text = "Interrogated the suspect.\nPress A to decrease stress. Press D to increase stress.\nPress 1 to ask the suspect their name.\nPress 2 to ask the suspect what they saw.\nPress 3 to stop talking to the suspect.\nCurrent Stress: " + stress + " Current State: " + current.ToString();

        //Changing state based on stress level
        if (stress <= 2)
        {
            current = relaxed;
        }
        if (stress > 2 && stress <= 5)
        {
            current = nervous;
        }
        if (stress > 5 && stress <= 8)
        {
            current = defensive;
        }
        if (stress > 8)
        {
            current = angered;
        }

        //Increasing and decreasing stress
        if (Input.GetKeyDown(KeyCode.A) && stress > 0)
        {
            stress--;
            text.text = "";
        }
        if (Input.GetKeyDown(KeyCode.D) && stress < 10)
        {
            stress++;
            text.text = "";
        }

        //Interacting with suspects based on current state
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            current.Introduce();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            current.AnswerQuestion();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            current.EndConversation();
        }
    }
}
