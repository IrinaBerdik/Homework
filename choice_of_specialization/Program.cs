string[] array_A = {"to", "7589", "fly", "in", "the", "sky", "hello", ":)"};
string[] new_array = new string [array_A.Length];
int j = 0;
for (int i = 0; i < array_A.Length; i++)
{
    if (array_A[i].Length <= 3)
    {
        new_array[j] = array_A[i];
        j++;
    }
}
for (int i = 0; i <= j; i++)
{
    Console.Write(new_array[i] + " ");
}
