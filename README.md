# Shift-Or-Algoritmasi
5220505051 - Barash Serbest 

  Shift-Or algoritması, dize eşleme (string matching) probleminin çözümü için bir algoritmadır. 
Verilen bir metin içinde belirtilen bir desenin (pattern) var olup olmadığını kontrol etmek 
için kullanılır. Algoritma, deseni önceden işleyerek desenin "maskeleme" işlemini yapar. 
Daha sonra metin üzerinde gezinirken, maskeleme işlemi kullanılarak desenin her harfinin 
metindeki harflerle karşılaştırılması gerçekleştirilir. Bu şekilde desenin geçtiği konumlar 
tespit edilir.

  Shift-Or algoritması, diğer string matching algoritmalarına göre daha hızlıdır ve özellikle
uzun metinlerde performansı iyi çalışır. Ancak, metin içindeki tüm eşleşmeleri bulmak için 
her karakter için maskeleme işlemi yapılması gerektiği için büyük boyutlu desenlerde performansı 
düşebilir.

  Bu örnekte, Shift-Or algoritması kullanılarak bir metin belgesindeki bir kelimenin kaç kez 
geçtiği bulunuyor. Algoritma, her karakterin bit maskeleme işlemiyle desenle karşılaştırılmasını 
gerçekleştirerek kelimenin geçtiği her konumu tespit ediyor. Sonuç olarak, belirtilen kelimenin 
metin belgesinde kaç kez geçtiği sayısını elde ediyor.
  
  Shift-Or algoritmasının çalışma zamanı, aranan kelimenin uzunluğu olan 'm' ile taranacak metnin 
uzunluğu olan 'n' arasındadır. En kötü durumda, Shift-Or algoritması 'O(mn)' zaman karmaşıklığına 
sahiptir.

  En iyi durumda, Shift-Or algoritması, aranan kelime metinde hiç geçmiyorsa, metnin tamamının 
okunmasıyla sınırlıdır ve bu durumda zaman karmaşıklığı 'O(n)' olur.

  Shift-Or algoritmasının ortalama çalışma zamanı, aranan kelimenin metindeki konumlarına ve 
uzunluğuna bağlıdır. Ancak genellikle diğer algoritmalardan daha hızlı olduğu bilinir.

  Shift-Or algoritması, aranan kelimenin bit maskeleme işlemi yaparak sorgulanması nedeniyle 
özellikle uzun metinlerde hızlı bir şekilde çalışır. Ancak, Shift-Or algoritması diğer 
algoritmalardan daha yavaş çalışan durumlar olabilir. 
