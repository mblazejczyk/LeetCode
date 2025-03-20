// https://leetcode.com/problems/kth-largest-sum-in-a-binary-tree/description/?envType=daily-question&envId=2025-03-20

public long KthLargestLevelSum(TreeNode root, int k) {
        List<TreeNode> queue = new List<TreeNode>();
        queue.Add(root);
        List<long> sums = new List<long>();

        while(queue.Count > 0){
            long tempsum = 0;
            List<TreeNode> next = new List<TreeNode>();

            foreach(TreeNode tn in queue){
                tempsum += tn.val;

                if(tn.left != null){
                    next.Add(tn.left);
                }
                if(tn.right != null){
                    next.Add(tn.right);
                }
            }
            
            sums.Add(tempsum);
            queue = next;
        }

        sums.Sort();
        if(k > sums.Count || sums[sums.Count - k] == 0){
            return -1;
        }
        return sums[sums.Count - k];
    }
