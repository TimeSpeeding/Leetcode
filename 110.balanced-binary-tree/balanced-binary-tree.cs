/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        return Math.Abs(Depth(root.left) - Depth(root.right)) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
    public int Depth(TreeNode root) {
        if (root == null) return 0;
        return Math.Max(Depth(root.left), Depth(root.right)) + 1;
    }
}