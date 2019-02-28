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
    public bool HasPathSum(TreeNode root, int sum) {
        if (root == null) return false;
        int newSum = sum - root.val;
        if (root.left == null && root.right == null && newSum == 0) return true;
        return HasPathSum(root.left, newSum) || HasPathSum(root.right, newSum);
    }
}