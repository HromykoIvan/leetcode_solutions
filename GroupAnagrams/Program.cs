// LeetCode 49. Group Anagrams — демонстрация и корректное решение.
//
// ИДЕЯ ЗАДАЧИ:
// Анаграммы — это слова с одинаковым набором букв и одинаковой кратностью каждой буквы.
// Пример: "eat", "tea", "ate" — у всех ровно по одной 'e', 'a', 't'.
// Значит, все анаграммы одного слова можно поместить в одну "корзину" по ОДИНАКОВОМУ ключу.
//
// ДВА КЛАССИЧЕСКИХ ПОДХОДА:
// 1) Отсортировать буквы слова → ключ. "eat" → "aet", "tea" → "aet". O(k log k) на слово.
// 2) Счётчик 26 букв → строка-ключ вида "#2#0#1..." или Join. O(k) на слово (k = длина слова).
//
// Здесь используем подход со счётчиком: он эффективнее при длинных строках и малом алфавите.

var sol = new Solution();
var result = sol.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);
PrintGroups(result);

/// <summary>
/// Печатает список групп для ручной проверки (не часть решения на LeetCode).
/// </summary>
static void PrintGroups(IList<IList<string>> groups)
{
    foreach (var group in groups)
        Console.WriteLine("[" + string.Join(", ", group.Select(s => $"\"{s}\"")) + "]");
}

public class Solution
{
    /// <summary>
    /// Группирует строки так, чтобы в одной группе были только взаимные анаграммы.
    /// </summary>
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        // Словарь: ключ = "подпись" набора букв, значение = список исходных слов с этой подписью.
        // Почему Dictionary, а не вложенные циклы по всем парам:
        // - Попарное сравнение даёт O(n² * k) и сложно корректно проверить "анаграммность".
        // - Однопроходный разбор с ключом даёт O(n * k) при фиксированном алфавите 26 букв.
        var buckets = new Dictionary<string, List<string>>();

        foreach (var word in strs)
        {
            // Подпись: сколько раз встретилась каждая из 26 строчных латинских букв.
            // Ограничение задачи: только 'a'..'z', длина слова ≤ 100 — массив из 26 int достаточен.
            var counts = new int[26];

            foreach (char ch in word)
            {
                // Смещение от 'a' даёт индекс 0..25.
                counts[ch - 'a']++;
            }

            // Строим строку-ключ фиксированного "формата", чтобы разные наборы не совпали случайно.
            // Пример: без разделителей "ab" могло бы слиться с чем-то неоднозначным при других схемах;
            // здесь явные разделители '#' делают ключ однозначным при восстановлении из чисел.
            var keyBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                keyBuilder.Append('#');
                keyBuilder.Append(counts[i]);
            }
            string key = keyBuilder.ToString();

            // Если такого ключа ещё не было — создаём новый список для новой группы анаграмм.
            if (!buckets.TryGetValue(key, out var list))
            {
                list = new List<string>();
                buckets[key] = list;
            }

            list.Add(word);
        }

        // IList<IList<string>> — тип возврата LeetCode; приводим списки к интерфейсу.
        return buckets.Values.Select(g => (IList<string>)g).ToList();
    }
}
