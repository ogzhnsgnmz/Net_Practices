try
{
    while (true)
    {
        var key = Console.ReadKey();
        if (key.Key == ConsoleKey.R)
            throw new CustomException("Laylaylom galiba sana göre sevmeler...")
            {
                MyProperty = 5
            };
        else
            Console.WriteLine(key.Key);
    }
}
catch (CustomException ex)
{

}

class CustomException : Exception
{
    public int MyProperty { get; set; }
    public CustomException() : base("")
    {
    }

    public CustomException(string? message) : base(message)
    {
    }
}