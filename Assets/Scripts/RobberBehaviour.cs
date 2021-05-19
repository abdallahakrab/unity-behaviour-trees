using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobberBehaviour : MonoBehaviour
{
    BehaviourTree tree;
    void Start()
    {
        // Cpnstructing tree
        tree = new BehaviourTree();
        Node steal = new Node("Steal Something");
        Node goToDiamond = new Node("Go to Diamond");
        Node goToVan = new Node("Go to Van");

        steal.AddChild(goToDiamond);
        steal.AddChild(goToVan);
        tree.AddChild(steal);
        tree.PrintTree();

    }

    void Update()
    {

    }
}
