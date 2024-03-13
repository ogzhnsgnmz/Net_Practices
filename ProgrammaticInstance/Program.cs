#region Acticator Sınıfı ile Nesne Oluşturma
Activator.CreateInstance(typeof(MyClass));
#endregion
#region DynamicObject Sınıfı ile Nesne Oluşturma

dynamic x = new MyClass();
x.A();

#endregion
#region Dynamic Keyword'ü ile Nesne Oluşturma
#endregion

class MyClass
{
    public MyClass()
    {
        Console.WriteLine($"{nameof(MyClass)} instance created.");
    }
}