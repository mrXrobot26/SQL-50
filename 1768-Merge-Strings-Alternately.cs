public class Solution {
    public string MergeAlternately(string word1, string word2) {
            var res = new StringBuilder();
            int minLen = Math.Min(word1.Length, word2.Length);

            for (int i = 0; i < minLen; i++)
            {
                res.Append(word1[i]);
                res.Append(word2[i]);
            }

            if (word1.Length > minLen)
                res.Append(word1.Substring(minLen));
            else if (word2.Length > minLen)
                res.Append(word2.Substring(minLen));

            return res.ToString();
    }
}