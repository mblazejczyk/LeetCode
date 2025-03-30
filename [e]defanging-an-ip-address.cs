// https://leetcode.com/problems/defanging-an-ip-address/
//really?

public class Solution {
    public string DefangIPaddr(string address) {
        return address.Replace(".", "[.]");
    }
}
