using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    // Node Status
    public enum Status
    {
        SUCCESS, RUNNING, FAILURE

    }
    public Status status;

    public List<Node> children = new List<Node>();

    // track of running child
    public int childNumber = 0;

    // For the sake of debugging
    public string name;

    //Constructors
    public Node()
    {

    }
    public Node(string name)
    {
        this.name = name;
    }

    public void AddChild(Node node)
    {
        children.Add(node);
    }
}
