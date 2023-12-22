//Array.CreateInstance metodu, belirli bir türde ve belirli bir boyutta bir dizi oluşturmak için kullanılır.
//Bu metot, Reflection (Yansıma) özelliğini kullanarak çalışır ve bir tür ve bir dizi boyutu parametreleri alır.
//Array.CreateInstance kullanılarak oluşturulan dizi, istenen türdeki öğeleri içerir ve boyutları
//belirtilen şekilde ayarlanır.

// int türünden, 3 elemanlı bir dizi oluştur
Array array = Array.CreateInstance(typeof(int), 3);

// Diziyi doldur
for (int i = 0; i < array.Length; i++)
{
    array.SetValue(i + 1, i); // Elemanları 1, 2, 3 olarak ayarla
}

// Diziyi yazdır
foreach (var item in array)
{
    Console.WriteLine(item);
}

//Bu örnekte, Array.CreateInstance metodu kullanılarak int türünden, 3 elemanlı bir dizi oluşturulur.
//Daha sonra SetValue metodu kullanılarak dizinin elemanları ayarlanır ve dizi içindeki elemanlar yazdırılır.

//Bu metot, özellikle çalışma zamanında tür bilgisine sahip olunmadığında dinamik olarak bir dizi oluşturmak
//istendiğinde ve Reflection kullanımı gerektiğinde kullanışlıdır. Ancak, performans açısından dikkatli
//kullanılmalıdır, çünkü Reflection maliyetli olabilir.

int[] a1 = (int[])Array.CreateInstance(typeof(int), 2);
int[,] a2 = (int[,])Array.CreateInstance(typeof(int), 2, 3);
int[,,] a3 = (int[,,])Array.CreateInstance(typeof(int), 2, 3, 4);

(int a, string b, bool c)[] a4 = new (int a, string b, bool c)[]
{
    (0, "j", true),
    (1, "k", false),
    (2, "l", true),
    (3, "ş", true),
    (4, "i", true),
};

(int a, string b)[,] a5 = new (int a, string b)[,]
{
    {
        (0, "j"),
        (1, "k"),
    },
    {
        (2, "l"),
        (3, "ş"),
    }
};