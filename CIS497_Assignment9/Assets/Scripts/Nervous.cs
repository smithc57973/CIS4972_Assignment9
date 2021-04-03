using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nervous : SuspectState
{
    SuspectAI sus;

    public Nervous(SuspectAI suspectAI)
    {
        this.sus = suspectAI;
    }

    public void AnswerQuestion()
    {
        sus.text.text = "I was doing weapons, but I definitely saw Blue in Reactor.";
    }

    public void EndConversation()
    {
        sus.text.text = "I have the last task, let me go do it real quick and you'll know I'm a crewmate.";
    }

    public void Introduce()
    {
        sus.text.text = "Yeah, I'm Red, why?";
    }
}
