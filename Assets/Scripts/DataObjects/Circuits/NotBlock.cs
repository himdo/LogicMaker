using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotBlock : CircuitBlock {
  public override void Init() {
    Value = 0;
  }
 
  public override bool IsSwitchedOn() {
    if (InputBlocks.Count > 1) 
    {
      Debug.Log("Not has to many inputs!");
      return false;
    }
    if (InputBlocks[0].Value > 0)
      return false;
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