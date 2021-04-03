using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angered : SuspectState
{
    SuspectAI sus;

    public Angered(SuspectAI suspectAI)
    {
        this.sus = suspectAI;
    }

    public void AnswerQuestion()
    {
        sus.text.text = "I saw Blue vent, vote Blue or I'm leaving.";
    }

    public void EndConversation()
    {
        sus.text.text = "I already voted you. End of conversation.";
    }

    public void Introduce()
    {
        sus.text.text = "We're on seven, if you don't know who I am by this point then you're either dumb or Jester.";
    }
}
