/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
class Solution {
    public List<List<Integer>> levelOrderBottom(TreeNode root) {
        List<List<Integer>> wraplist = new LinkedList<List<Integer>>();
        LevelOrder(wraplist, root, 0);
        return wraplist;
    }
    public void LevelOrder(List<List<Integer>> list, TreeNode root, int level) {
        if (root == null) return;
        if (level >= list.size()) list.add(0, new LinkedList<Integer>());
        LevelOrder(list, root.left, level + 1);
        LevelOrder(list, root.right, level + 1);
        list.get(list.size() - level - 1).add(root.val);
    }
}