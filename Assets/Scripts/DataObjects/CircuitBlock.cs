using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitBlock : MonoBehaviour
{
  public float Value;
  public List<CircuitBlock> InputBlocks;
  public List<GameObject> LineObjects;
  // Start is called before the first frame update
  void Start()
  {
    DrawInputLines();
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

  void DrawInputLines() {
    for (int i = 0; i < InputBlocks.Count; i++) { 
      GameObject lineObject = new GameObject();
      lineObject.transform.position = this.gameObject.transform.position;
      LineRenderer lr = lineObject.AddComponent<LineRenderer>();
      lr.material = new Material(Shader.Find("Standard"));
      // lr.SetColors(color, color);
      lr.startWidth = 0.1f;
      lr.endWidth = 0.1f;
      // lr.widthCurve = 0.1f;
      lr.SetPosition(0, this.gameObject.transform.position);
      lr.SetPosition(1, InputBlocks[i].gameObject.transform.position);
      LineObjects.Add(lineObject);
    }
  }

  public virtual void Init() { }
  public virtual bool IsSwitchedOn() { return false; }
  public virtual void OnAction() { }
  public virtual void OffAction() { }
}
