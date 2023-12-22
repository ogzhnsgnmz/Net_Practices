// ref:

//ref, C# dilinde bir parametre geçme ve değer döndürme mekanizmasıdır. "Referans" anlamına gelir ve ref
//anahtar kelimesi ile birlikte kullanıldığında, bir değişkenin değerini bir metodun içinde referans
//üzerinden değiştirmenizi sağlar.

//Normalde, C# dilinde parametre geçme işlemi değer ile yapılır. Bu, bir metoda geçirilen değişkenin
//kopyasının oluşturulduğu ve bu kopyanın metot içinde kullanıldığı anlamına gelir. Ancak, ref anahtar
//kelimesi kullanıldığında, değişkenin kendisi geçirilir ve bu sayede metot içinde yapılan değişiklikler,
//orijinal değişkene yansır.

// Bu metot, bir int değerini artırır.
void IncreaseNumber(ref int number)
{
    number++;
}

int myNumber = 5;

// ref anahtar kelimesi ile metoda geçirilen değişkenin değeri metot içinde değişebilir.
IncreaseNumber(ref myNumber);

Console.WriteLine(myNumber); // Çıktı: 6

// Bu örnekte, IncreaseNumber metodu, ref ile işaretlenmiş bir int parametre alır. Bu sayede,
// metot içinde yapılan değişiklik, orijinal myNumber değişkenine etki eder.

// ref kullanımına dikkat edilmelidir, çünkü yanlış kullanım beklenmeyen sonuçlara yol açabilir. 
// ref kullanırken, değişkenin başlangıç değeri verilmelidir, aksi takdirde bir derleme hatası
// alabilirsiniz. Ayrıca, ref kullanımı kodu daha karmaşık hale getirebilir ve gereksiz yere
// değerleri değiştirmek gibi yan etkilerle sonuçlanabilir. Bu nedenle, ref kullanımını dikkatli
// bir şekilde değerlendirmek önemlidir.



// ref return:
//ref return, C# 7.0 sürümü ile birlikte dilin içine eklenen bir özelliktir. Bu özellik, bir
//metotun değerini değil, doğrudan bir değeri referans olarak döndürme yeteneğini sağlar. Bu,
//özellikle performans veya bazı özel durumlarda değer tipi nesneler üzerinde işlem yaparken
//kullanışlı olabilir.

int[] numbers = { 1, 2, 3, 4, 5 };

// Bu metot, numbers dizisindeki belirli bir indeksteki değeri referans olarak döndürür.
ref int GetNumberAtIndex(int index)
{
    return ref numbers[index];
}

// İndeks 2'deki değeri referans olarak al
ref int number = ref GetNumberAtIndex(2);

// Değeri değiştir
number = 10;

// Önceki değişiklik, numbers dizisine de yansır
Console.WriteLine(GetNumberAtIndex(2)); // Çıktı: 10

//Bu örnekte, GetNumberAtIndex metodu, numbers dizisinin belirli bir indeksindeki değeri referans
//olarak döndürmektedir. ref int ifadesi, değeri referans olarak almak istediğimizi belirtir.
//Bu sayede, bu referans üzerinden yapılan değişiklikler, asıl veri yapısına da etki eder.

//ref return özelliği, performans avantajları sağlamak veya bazı özel durumları ele almak için kullanılabilir.
//Ancak, dikkatlice kullanılmalıdır, çünkü değeri referans olarak döndürmek, beklenmeyen sonuçlara yol
//açabilir ve kodun okunabilirliğini azaltabilir. Bu nedenle, ihtiyaçlarınıza ve proje gereksinimlerinize
//bağlı olarak kullanımını değerlendirmelisiniz.

int b = 5;
ref int c = ref X(ref b); // Referans olarak dönen değerin referansını oluşturmak.
//int c = X(ref b); // Referans olarak dönen değerin değerini oluşturmak.
Console.WriteLine(b); 
Console.WriteLine(c);

ref int X(ref int a)
{
    a = 123;
    return ref a;
}

//ref return özelliği kullanılarak bir metot içinde tanımlanan lokal değişkenler doğrudan döndürülemez.
//ref return, genellikle bir metodun içinde tanımlanan yerel bir değişkenin referansını döndürme yeteneğini
//sağlar ancak bu yerel değişkenlerin tamamen metot çağrısı bittikten sonra dağınık bellek olmaması için tasarlanmıştır.
//daha çok, referans türlerinde bellek maliyetini azaltmak veya performansı artırmak için büyük veri yapıları
//üzerinde çalışma amacıyla kullanılır.

int[] numbrs = { 1, 2, 3, 4, 5 };
ref int numberRef = ref FindElement(numbrs, 3);

ref int FindElement(int[] array, int target)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == target)
            return ref array[i];
    throw new InvalidOperationException("Item not found");
}



// ref locals:
//ref locals, C# dilinde bir değişkenin değil, bir değişkenin kendisinin referansının alınmasını sağlayan bir özelliktir.
//Bu özellik, bir değişkenin değerini değil, bellekteki gerçek konumunu paylaşmanıza olanak tanır. Bu, aynı bellek
//konumunu kullanarak değişken üzerinde yapılan değişikliklerin, tüm referansların etkilenmesine neden olacağı anlamına gelir.

int originalValue = 10;

// ref local kullanarak referans alınması
ref int reference = ref originalValue;

Console.WriteLine($"Original Value: {originalValue}");
Console.WriteLine($"Reference Value: {reference}");

// Referans üzerinde yapılan değişiklik, orijinal değeri etkiler
reference = 20;
Console.WriteLine($"Modified Original Value: {originalValue}");