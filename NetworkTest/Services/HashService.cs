namespace NetworkTest.Services;

public static class HashService
{
    public static string HashLog(this string input)
    {
        if (input == null) return null;
        if (input == "") return "";

        var salt = "&o%q2*SUY9r%#EguSuvy#py4R4";
        byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);

        byte[] combinedBytes = new byte[saltBytes.Length + inputBytes.Length];
        Array.Copy(saltBytes, 0, combinedBytes, 0, saltBytes.Length);
        Array.Copy(inputBytes, 0, combinedBytes, saltBytes.Length, inputBytes.Length);

        byte[] hashBytes = SHA256.HashData(combinedBytes);

        StringBuilder builder = new();

        for (int i = 0; i < hashBytes.Length; i++)
        {
            builder.Append(hashBytes[i].ToString("x2"));
        }
        return builder.ToString();
    }
}
