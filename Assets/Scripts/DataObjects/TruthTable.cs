using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// // Define the logic of the AND gate using a lambda function.
// Func<bool[], bool> andGateFunc = inputs => inputs[0] && inputs[1];

// // Create an AND gate with input1 = true and input2 = false.
// var andGate = new TruthTable(new bool[] { true, false }, andGateFunc);

// // Print the output of the AND gate.
// Console.WriteLine(andGate.Output); // Output: false
[Serializable]
public class TruthTable
{
    // The inputs for the truth table.
    [SerializeField]
    private bool[] Inputs { get; set; }

    [SerializeField]
    private Func<bool[], bool> GateFunc { get; set; }

    // Constructor that takes the values of the input variables and calculates the output.
    public TruthTable(bool[] inputs, Func<bool[], bool> gateFunc)
    {
        Inputs = inputs;
        GateFunc = gateFunc;
    }

    public void UpdateInputs(bool[] inputs) 
    {
        Inputs = inputs;
    }

    public bool GetOutPut()
    {
        return GateFunc(Inputs);
    }
}
