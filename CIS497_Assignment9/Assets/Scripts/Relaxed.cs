using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relaxed : SuspectState
{
    SuspectAI sus;

    public Relaxed(SuspectAI suspectAI)
    {
        this.sus = suspectAI;
    }

    public void AnswerQuestion()
    {
        sus.text.text = "Oh yeah, I saw Blue coming from Medbay.";
    }

    public void EndConversation()
    {
        sus.text.text = "Hey, I've got to go do my Simon Says, did you have any more questions?";
    }

    public void Introduce()
    {
        sus.text.text = "Hi, I'm Red, and I am not sus.";
    }

}
