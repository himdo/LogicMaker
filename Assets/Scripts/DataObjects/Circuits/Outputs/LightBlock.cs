using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlock : CircuitBlock {

  [SerializeField]
  Sprite LightOnSprite;

  [SerializeField]
  Sprite LightOffSprite;

  SpriteRenderer GameObjectSpriteRender;
  public override void Init() {
    Value = 0;
    GameObjectSpriteRender = this.gameObject.GetComponent<SpriteRenderer>();
    GameObjectSpriteRender.sprite = LightOffSprite;
  }
 
  public override bool IsSwitchedOn() {
    // the light will only turn on if all inputs are greater than 0
    foreach(CircuitBlock input in InputBlocks)
      if (input.Value <= 0)
        return false;

      return true;
  }
 
  public override void OnAction() {
    if (Value == 0) {
      Value = 1;
      GameObjectSpriteRender.sprite = LightOnSprite;
    }
  }
   
  public override void OffAction() {
    if (Value == 1) {
      Value = 0;
      GameObjectSpriteRender.sprite = LightOffSprite;
    }
  }
}