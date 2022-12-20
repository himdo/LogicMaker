using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NandBlock : CircuitBlock {
  public override void Init() {
    Value = 0;
  }

  public override bool IsSwitchedOn() {
    // if all inputs are true then return false else return true
    foreach(CircuitBlock input in InputBlocks) {
      if (input.Value == 0)
        return true;
    }

    return false;
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