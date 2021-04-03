using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defensive : SuspectState
{
    SuspectAI sus;

    public Defensive(SuspectAI suspectAI)
    {
        this.sus = suspectAI;
    }

    public void AnswerQuestion()
    {
        sus.text.text = "Are you accusing me? I bet you're the impostor! What tasks have you done?";
    }

    public void EndConversation()
    {
        sus.text.text = "I don't have to answer your questions. I'm skipping.";
    }

    public void Introduce()
    {
        sus.text.text = "Are you blind? I'm obviously Red.";
    }
}
