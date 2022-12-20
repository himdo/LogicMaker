using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorBlock : CircuitBlock {
  public override void Init() {
    Value = 0;
  }

  public override bool IsSwitchedOn() {
    // if all inputs are false then return true else return false
    foreach(CircuitBlock input in InputBlocks) {
      if (input.Value == 1)
        return false;
    }

    return true;
  }

  public override void OnAction() {
    if (Value == 0) {
      Value = 1;
    }
  }

  public override void OffAction() {
    if (Value == 1) {
      Value = 0;
    }
  }
}