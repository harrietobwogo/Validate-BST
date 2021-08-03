using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }

  public static bool ValidateBst(TreeNode root, int min,int max){
    bool valid=true;

    if(root==null){
      return valid;
    }
    if(root.val<=min|| root.val>max){
      valid=false;
    }
    if(root.left!=null){
      valid=ValidateBst(root.left,min, root.val);
    }
    if(root.right!=null&& valid){
      valid=ValidateBst(root.right,root.val,max);
    }

    return valid;
  }
  public static bool ValidBST(TreeNode root){
    return ValidateBst(root,int.MinValue, int.MaxValue);
  }
}
  public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 