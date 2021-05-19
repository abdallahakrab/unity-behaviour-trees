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
        string s = "";
        int i = 0;
        Print(this, ref s, i);
        Debug.Log(s);
    }

    private void Print(Node node, ref string printText, int level)
    {
        if (node == null)
        {
            return;

        }
        printText += new string('\t', level) + node.name + "\n";
        if (node.children.Count == 0)
        {
            return;
        }
        level++;
        foreach (Node child in node.children)
        {
            Print(child, ref printText, level);
        }

    }
}
