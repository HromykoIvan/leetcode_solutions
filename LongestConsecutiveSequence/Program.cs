var sol = new Solution();

int[] nums = [100,4,200,1,3,2];
var result = sol.LongestConsecutive(nums);
Console.WriteLine("Answer is: " + string.Join(", ", result));

public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        var longestConsecutive = 0;

        // HashSet даёт поиск за O(1) и убирает дубликаты (нужно для примера [1,0,1,2]).
        HashSet<int> set = new HashSet<int>(nums);

        foreach (var num in set)
        {
            // Проверяем, что num - НАЧАЛО цепочки, а не её середина.
            // Если (num - 1) есть в сете, значит цепочка начинается раньше,
            // и мы её уже посчитаем (или посчитали) от настоящего начала.
            // Без этой проверки while ниже запускался бы для каждого числа,
            // и алгоритм превратился бы в O(n^2) вместо требуемого O(n).
            if (set.Contains(num - 1)) continue;

            int length = 1;
            // Идём вперёд (num, num+1, num+2, ...), пока следующее число есть в сете.
            while (set.Contains(num + length)) length++;

            longestConsecutive = Math.Max(longestConsecutive, length);
        }

        // Возвращаем длину самой длинной цепочки, а не количество элементов в сете.
        return longestConsecutive;
    }
}