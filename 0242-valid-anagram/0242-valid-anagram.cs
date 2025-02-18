public class Solution {
    public bool IsAnagram(string s, string t) {
        //Words to CharArray
        char[] wordS = s.ToCharArray();
        char[] wordT = t.ToCharArray();

        //Sort in alphabetical order
        Array.Sort(wordS);
        Array.Sort(wordT);

        string orderedS = new string (wordS);
        string orderedT = new string (wordT);

        if (orderedS == orderedT) {
            return true;
        } else {
            return false;
        }
    }
}