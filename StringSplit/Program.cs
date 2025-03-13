string words = "Дана строка с  текстом, используя метод строки String.Split() получить массив слов, которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки.";

string[]  arrayWords = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

foreach (string word in arrayWords)
{
	Console.WriteLine(word);
}