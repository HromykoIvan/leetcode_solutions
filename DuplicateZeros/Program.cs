var sol = new Solution();
var result = sol.DuplicateZeros(new[] {1,0,2,3,0,4,5,0});
string arrayString = "[" + String.Join(",", result) + "]";
Console.WriteLine(arrayString);

public class Solution {
    public int[] DuplicateZeros(int[] arr) {
        var n = arr.Length;
        var {REMOVED_TOKEN} = 0;
        int i;

        for (i = 0; i < n - {REMOVED_TOKEN}; i++) {
            if (arr[i] == 0) {
                if (i == n - {REMOVED_TOKEN} - 1) {
                    arr[n - 1] = 0;
                    n--;
                    break;
                }
                {REMOVED_TOKEN}++;
            }
        }

        var last = n - {REMOVED_TOKEN} - 1;
        for (i = last; i >= 0; i--) {
            if (arr[i] == 0) {
                arr[i + {REMOVED_TOKEN}] = 0;
                {REMOVED_TOKEN}--;
                arr[i + {REMOVED_TOKEN}] = 0;
            } else {
                arr[i + {REMOVED_TOKEN}] = arr[i];
            }
        }

        return arr;
    }
}