using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InstructionElement : MonoBehaviour
{
    protected abstract void InstructionUpdate(InstructionStep step);

    private void Awake()
    {
        FindObjectOfType<InstructionsController>().OnInstructionUpdate.AddListener(InstructionUpdate);
    }
}
