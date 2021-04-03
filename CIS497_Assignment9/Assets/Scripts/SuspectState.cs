/*
 * Chris Smith
 * SuspectState
 * Assignment 9
 * An interface defining the methods of a Suspect's State.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface SuspectState
{
    void Introduce();
    void AnswerQuestion();
    void EndConversation();
}
