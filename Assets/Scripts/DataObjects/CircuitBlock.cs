using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitBlock : MonoBehaviour
{
  public float Value;
  public List<CircuitBlock> InputBlocks;
  // Start is called before the first frame update
  void Start()
  {
    Init();
  }

  // Update is called once per frame
  void Update()
  {
    if (IsSwitchedOn())
      OnAction();
    else
      OffAction();
  }

  public virtual void Init() { }
  public virtual bool IsSwitchedOn() { return false; }
  public virtual void OnAction() { }
  public virtual void OffAction() { }
}
