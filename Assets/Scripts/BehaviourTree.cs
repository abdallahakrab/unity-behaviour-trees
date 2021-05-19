using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTree : Node
{

    public BehaviourTree()
    {
        name = "Tree";
    }
    public BehaviourTree(string name)
    {
        this.name = name;
    }

    public void PrintTree()
    {
        Print(this);
    }

    private void Print(Node node)
    {
        if (node == null)
        {
            return;

        }
        Debug.Log(node.name);
        if (node.children.Count == 0)
        {
            return;
        }
        foreach (Node child in node.children)
        {
            Print(child);
        }

    }
}
