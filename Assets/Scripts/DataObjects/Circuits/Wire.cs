using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : CircuitBlock {
  public override void Init() {
    Value = 0;
  }
 
  public override bool IsSwitchedOn() {
    foreach(CircuitBlock input in InputBlocks)
      return input.Value != 0;
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