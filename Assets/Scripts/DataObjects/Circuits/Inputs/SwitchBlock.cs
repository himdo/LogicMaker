using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBlock : CircuitBlock {
  public bool SwitchEnabled;

  [SerializeField]
  Sprite OnSprite;

  [SerializeField]
  Sprite OffSprite;
  SpriteRenderer GameObjectSpriteRender;
  public override void Init() {
    SwitchEnabled = false;
    Value = 0;
    GameObjectSpriteRender = this.gameObject.GetComponent<SpriteRenderer>();
    GameObjectSpriteRender.sprite = OffSprite;
  }

  public override bool IsSwitchedOn() {
    // the light will only turn on if all inputs are greater than 0
    return SwitchEnabled;
  }

  public override void OnAction() {
    if (Value == 0) {
      Value = 1;
      GameObjectSpriteRender.sprite = OnSprite;
    }
  }
  
  public override void OffAction() {
    if (Value == 1) {
      Value = 0;
      GameObjectSpriteRender.sprite = OffSprite;
    }
  }

  void OnMouseDown() {
    if (Value == 1) 
      SwitchEnabled = false;
    else 
      SwitchEnabled = true;
  }
}