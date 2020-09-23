
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InstructionEvent : UnityEvent<InstructionStep> { }
public class InstructionsController : MonoBehaviour
{

    private int currentStep;

    private InstructionModel currentInstructionModel = new InstructionModel();

    public InstructionEvent OnInstructionUpdate = new InstructionEvent();

    private void CurrentInstructionUpdate()
    {
        InstructionStep step = currentInstructionModel.GetInstructionStep(currentStep);
        OnInstructionUpdate.Invoke(step);
    }

    public void NextStep()
    {
        if(currentStep < currentInstructionModel.GetCount() - 1)
        {
            currentStep++;
            CurrentInstructionUpdate();
        }
    }

    public void PreviousStep()
    {
         if(currentStep > 0)
        {
            currentStep--;
            CurrentInstructionUpdate();
        }
    }

    void Awake()
    {
        currentInstructionModel.LoadData();
    }

}
