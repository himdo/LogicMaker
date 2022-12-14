using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBlock : CircuitBlock {
  public bool SwitchEnabled;

  public override void Init() {
    SwitchEnabled = false;
    Value = 0;
  }

  public override bool IsSwitchedOn() {
    // the light will only turn on if all inputs are greater than 0
    return SwitchEnabled;
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