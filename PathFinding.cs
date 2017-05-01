using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinding : MonoBehaviour {

	public enum Directions {Forward, Right, Left, Backward};

	public class Node {
		int f, g, h;
		bool walkable;
	}

	public int gridWorldSize = 21;

	public Node[,] gridMap;

	public List<Node> open_list;

	public List<Node> closed_list;

	void Start () {
		gridMap = new Node[gridWorldSize, gridWorldSize];
	}

	public List<Directions> pathfinding(Vector3 start, Vector3 end){
		
	}

	void Update () {
		
	}
}
