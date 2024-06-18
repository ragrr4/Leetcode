// Note: too heavy on memory
public class Solution {
    Node root = new Node(0);
    int pathCount = 0;

    public int ClimbStairs(int n) {
        FillTree(root, n);
        return pathCount;
    }

    public void FillTree(Node node, int limit) {
        if(node.value == limit){
            pathCount += 1;
            return;
        }
        if(node.value + 1 <= limit) {
            node.left = new Node(node.value + 1);
            FillTree(node.left, limit);
        }
        if(node.value + 2 <= limit) {
            node.right = new Node(node.value + 2);
            FillTree(node.right, limit);
        }
    }

    public class Node {
        public int value {get; set;}
        public Node left = null;
        public Node right = null;
        public Node (int value){
            this.value = value;
        }
    }
}