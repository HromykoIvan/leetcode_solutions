var sol = new Solution();
var result = sol.DuplicateZeros(new[] {1,0,2,3,0,4,5,0});
string arrayString = "[" + String.Join(",", result) + "]";
Console.WriteLine(arrayString);

public class Solution {
    public int[] DuplicateZeros(int[] arr) {
        var n = arr.Length;
        var zerosToDuplicate = 0;
        int i;

        for (i = 0; i < n - zerosToDuplicate; i++) {
            if (arr[i] == 0) {
                if (i == n - zerosToDuplicate - 1) {
                    arr[n - 1] = 0;
                    n--;
                    break;
                }
                zerosToDuplicate++;
            }
        }

        var last = n - zerosToDuplicate - 1;
        for (i = last; i >= 0; i--) {
            if (arr[i] == 0) {
                arr[i + zerosToDuplicate] = 0;
                zerosToDuplicate--;
                arr[i + zerosToDuplicate] = 0;
            } else {
                arr[i + zerosToDuplicate] = arr[i];
            }
        }

        return arr;
    }
}