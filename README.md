# unity-behaviour-trees

Walkthrough Unity's Behavior Trees Course

---

# Notes

Quick course notes

---

## Intro

Control Behaviour of NPCS

Node types: Composite | Decorator | Leaf

Composite: One or more node

- Sequence: Children executed in order
- Selector: One is picked

Decorator: one child

Leaf: repersent action, each must represent a method

method to report state (success / fail)

---

## Nodes

**Node attributes**: Status | Children | ChildNumber | Name

- Status: Can be Running, Success, Failure
- Children: List of nodes
- ChildNumber: Current child being executed
- Name: For Easier Debugging
