//C# dilinde, operatör aşırı yüklenmesi (operator overloading), özel bir sınıf veya yapı (class veya struct)
//içinde bulunan operatörlerin özelleştirilerek kendi türlerimize uygun hale getirilmesini sağlayan bir özelliktir.
//Bu, programcılara kendi veri tiplerini oluşturduklarında, bu tipler üzerinde standart operatörleri kullanabilmelerini sağlar.

public class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // + operatörünü aşırı yükleme
    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // ToString metodu aşırı yükleniyor, bu sayede Console.WriteLine içinde direkt ComplexNumber nesnesi kullanılabilecek.
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program2
{
    static void Main()
    {
        ComplexNumber complex1 = new ComplexNumber(1, 2);
        ComplexNumber complex2 = new ComplexNumber(3, 4);

        // + operatörü aşırı yüklendiği için doğrudan kullanılabilir.
        ComplexNumber result = complex1 + complex2;

        Console.WriteLine("Result: " + result); // ToString metodu çağrılır.
    }
}

//Bu örnekte, ComplexNumber adlı bir sınıf tanımlanmış ve + (toplama) operatörü aşırı yüklenmiştir.
//Bu sayede, iki ComplexNumber nesnesi doğrudan + operatörü ile toplanabilir. Operatör aşırı yüklenmiş metotlar,
//özel bir anahtar kelime olan operator kullanılarak tanımlanır.

//Operatör aşırı yüklemesi genellikle türler arasında doğal bir anlam ifade ettiğinde veya kullanıcılara daha
//okunabilir ve anlaşılır bir API sunmak istediğinizde kullanılır. Ancak, aşırı kullanıldığında kodun karmaşık
//hale gelmesine ve anlaşılabilirliğin azalmasına neden olabilir, bu nedenle dikkatlice kullanılmalıdır.

class Category
{
    public string Name { get; set; }
    public List<Quote> Quotes { get; set; } = new();
}

class Quote
{
    public string Text { get; set; }
    public string Person { get; set; }
}

class Program3
{
    static void Main()
    {
        Category category = new()
        {
            Name = "Futbol"
        };

        Quote quote = new()
        {
            Text = "Benim kitabımda vazgeçmek de yenilmek de yoktur... Ben kaybedenlere asla kızmam. Ama vazgeçenleri ve yenilgiyi baştan kabul edenleri siler atarım. Kaybetse de sonuna kadar mücadele edenler benim her zaman yanımda olacak ve onlar sonunda mutlaka kazanacak.",
            Person = "Fatih Terim"
        };
        //var s = category + quote; // hata!
    }
}