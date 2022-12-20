using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XorBlock : CircuitBlock {
  public override void Init() {
    Value = 0;
  }

  public override bool IsSwitchedOn() {
    // returns true when there is an odd number of 1s else return false
    int oneCount = 0;
    foreach(CircuitBlock input in InputBlocks) {
      if (input.Value == 1)
        oneCount++;
    }
    if (oneCount % 2 == 1) {
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