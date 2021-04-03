using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface SuspectState
{
    void Introduce();
    void AnswerQuestion();
    void EndConversation();
}
