using System.Dynamic;

#region Acticator Sınıfı ile Nesne Oluşturma
Activator.CreateInstance(typeof(MyClass));
#endregion

#region DynamicObject Sınıfı ile Nesne Oluşturma
dynamic instance = new MyClass();
instance.DynamicProperty1 = "123";
instance.DynamicProperty2 = 123;

MyClass _instance = (MyClass)instance;
//_instance.WriteMembers(); derleme zamanı hatası.
#endregion

#region Dynamic Keyword'ü ile Nesne Oluşturma
dynamic instance2 = new ExpandoObject();
instance2.DynamicProperty1 = "123";
instance2.DynamicProperty2 = 123;
#endregion

class MyClass : DynamicObject
{
    public MyClass()
    {
        Console.WriteLine($"{nameof(MyClass)} instance created.");
    }

    readonly private Dictionary<string, object> properties = new();

    public override bool TrySetMember(SetMemberBinder binder, object? value)
    {
        properties.Add(binder.Name, value);
        return true;
    }

    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        return properties.TryGetValue(binder.Name, out result);
    }
}