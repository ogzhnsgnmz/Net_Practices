// Implicit:

// Implicit conversion (belli bir türden diğer bir türe otomatik dönüşüm) C# programlamada
// sıkça kullanılan bir kavramdır. Bu dönüşüm, derleyici tarafından otomatik olarak gerçekleştirilir
// ve programcının müdahalesine gerek kalmaz. Bu tür dönüşümler genellikle küçükten büyüğe veya
// daha genel bir türden daha özele yapılan dönüşümleri içerir.

int integerNumber = 42;
double doubleNumber = integerNumber; // Implicit conversion

Console.WriteLine($"Integer: {integerNumber}");
Console.WriteLine($"Double: {doubleNumber}");

//Bu örnekte, int türündeki bir değişken (integerNumber), double türüne otomatik olarak dönüştürülüyor.
//Bu dönüşüm, küçük bir türden (int) daha büyük bir türe (double) doğru ve güvenli bir şekilde
//yapılabileceği için implicit olarak adlandırılır.

//Bu tür dönüşümler genellikle tür uyumluluğunu artırmak ve programcının işini kolaylaştırmak amacıyla
//kullanılır. Ancak, dönüşüm işlemi sırasında veri kaybı olabileceği durumlarda dikkatli olunmalıdır.
//Eğer veri kaybını önlemek veya daha karmaşık dönüşümler yapmak istiyorsanız, explicit (açık) dönüşüm
//(casting) kullanmanız gerekebilir.

// Explicit:

//Explicit conversion (açık dönüşüm), bir türden diğer bir türe dönüşümü ifade eder ve bu dönüşümü
//gerçekleştirmek için programcının belirli bir ifade kullanması gerekir. Bu tür dönüşümler genellikle
//daha spesifik ve kontrollü bir şekilde yapılır. Eğer dönüşüm güvenli bir şekilde yapılamayacaksa,
//derleyici hata verecektir.

//C# dilinde explicit dönüşüm, iki şekilde gerçekleştirilebilir: cast operatörü ((targetType)expression)
//veya Convert sınıfı gibi özel dönüşüm metotları kullanılarak.

double doubleNumber2 = 42.56;
int integerNumber2;

// Explicit conversion using cast operator
integerNumber2 = (int)doubleNumber2;

Console.WriteLine($"Double: {doubleNumber2}");
Console.WriteLine($"Integer: {integerNumber2}");

//Bu örnekte, double türündeki bir değişken (doubleNumber), int türüne cast operatörü ((int)) kullanılarak
//açık bir şekilde dönüştürülmüştür. Bu dönüşüm, bazen veri kaybına neden olabilir ve programcı tarafından
//dikkatlice kontrol edilmelidir.

//Açık dönüşümler genellikle türler arasında uyumsuzluk olduğunda veya dönüşümün açıkça belirtilmesi
//gerektiğinde kullanılır. Ancak, güvenli ve otomatik dönüşüm mümkünse, implicit conversion genellikle
//tercih edilir.