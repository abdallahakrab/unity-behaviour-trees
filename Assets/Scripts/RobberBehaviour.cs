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

        // Node eat = new Node("Eat Something");
        // Node bread = new Node("Bread");
        // Node meat = new Node("Meat");

        // eat.AddChild(bread);
        // eat.AddChild(meat);
        // tree.AddChild(eat);

        tree.PrintTree();
    }

    void Update()
    {

    }
}
