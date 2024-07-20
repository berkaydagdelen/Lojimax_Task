public class Program
{
    public static void Main()
    {
        // Soru 1: Diziyi tersten sıralama
        ReverseArray();

        // Soru 2: Anagram kontrolü
        CheckAnagram();

        // Soru 3: Bağlı listede döngü tespiti
        DetectCycleInLinkedList();

        // Soru 4: Matrisin elemanlarını 90 derece döndürüp yansıtma
        PrintMatrixAndReflection();

        // Soru 5: Fibonacci dizisi oluşturma
        GenerateFibonacci();
    }

    public static void ReverseArray()
    {
        int[] numbers = { 1, 3, 4, 5, 6 };
        string reverse = "";
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            reverse += numbers[i];
        }
        Console.WriteLine(reverse);


        //****verilen diziyi uzunluğun başlangıcına koyup 0 a kadar döngüyü döndürerek geriye doğru sıralamasını sağladım.****
    }

    public static void CheckAnagram()
    {
        string str1 = "deger";
        string str2 = "dereg";

        char[] chr1 = str1.ToLower().ToCharArray();
        char[] chr2 = str2.ToLower().ToCharArray();

        Array.Sort(chr1);
        Array.Sort(chr2);

        string val1 = new string(chr1);
        string val2 = new string(chr2);

        if (val1 == val2)
        {
            Console.WriteLine("Anagramdır");
        }
        else
        {
            Console.WriteLine("Anagram değildir");
        }


        //**** ilk başta aldığımız değerleri küçük harfe çevirip onuda char tipine çeviriyorum sonra 2 diziyi de
        //sıralıyorum sonrada yeni bir string nesnesi oluşturup bunları karşılaştırıyorum***

    }

    public class ListNode
    {
        public int Value;
        public ListNode Next;

        public ListNode(int value = 0, ListNode next = null)
        {
            Value = value;
            Next = next;
        }
    }

    public class LinkedListCycleDetector
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.Next == null)
            {
                return false;
            }

            ListNode slow = head;
            ListNode fast = head.Next;

            while (slow != fast)
            {
                if (fast == null || fast.Next == null)
                {
                    return false;
                }

                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return true;
        }
    }

    public static void DetectCycleInLinkedList()
    {
        ListNode node1 = new ListNode(3);
        ListNode node2 = new ListNode(2);
        ListNode node3 = new ListNode(0);
        ListNode node4 = new ListNode(-4);

        node1.Next = node2;
        node2.Next = node3;
        node3.Next = node4;
        node4.Next = node2; 

        LinkedListCycleDetector detector = new LinkedListCycleDetector();
        bool hasCycle = detector.HasCycle(node1);
        Console.WriteLine(hasCycle ? "Liste döngü içeriyor." : "Liste döngü içermiyor.");


        //****
        //ilk olarak bağlı listenin düğümünü temsil eden bir sınıf oluşturdum.
        //her bir düğümün değerine (Value)  bir sonraki düğümü işaret eden değere(Next) dedim.

        //bağlı listede döngü olup olmadığını kontrol eden fonksiyon yazdım.
        //biri yavaş (slow), diğeri hızlı (fast) iki işaretçi oluşturdum.
        //Hızlı işaretçi ve yavaş işaretçi aynı düğüme ulaşana kadar döngüyü sürdürür.
        //Eğer fast işaretçi null'a veya fast.Next null'a ulaşırsa, döngü yok demektir.
        //Yavaş işaretçi bir adım ilerler  Hızlı işaretçi iki adım ilerler.
        //Eğer döngüden çıkmamızın sebebi slow ve fast'in aynı düğümde buluşması ise, döngü vardır

        //Örnek bir bağlı liste oluşturdum sonra Düğümleri birbirine bağlayıp döngü oluşturdum.
        //En son da döngü kontrolü yaptım.
        //****


    }

    public static void PrintMatrixAndReflection()
    {
        Console.WriteLine("Satır sayısı giriniz:");
        int satir = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sütun sayısı giriniz:");
        int sutun = Convert.ToInt32(Console.ReadLine());
        int[,] matris = new int[satir, sutun];

        Console.WriteLine("\nMatris:");
        for (int i = 0; i < satir; i++)
        {
            for (int k = 0; k < sutun; k++)
            {
                matris[i, k] = i + k;
                Console.Write(matris[i, k] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n -----------Yansıma--------- \n");
        for (int i = 0; i < satir; i++)
        {
            for (int k = sutun - 1; k >= 0; k--)
            {
                Console.Write(matris[i, k] + " ");
            }
            Console.WriteLine();
        }

        //****ilk başta değerlerimi alıyorum sonra iki boyutlu tamsayı dizisi oluşturdum iç içe döngü ile matrisin her elemanına i+k değeri ile doldurdum i satır k da sutun demek oluyor.
        //sonrada tekrardan iç içe sorgu yaptım 90 derece döndürmek için ikinci döngüyü tersten döndüm ve her seferinde ekrana yazdırıyorum.
        //ikinci döngü bitince de alt satıra geçiyor.****

    }

    public static void GenerateFibonacci()
    {
        string array = "";

        int number = 0;
        int a = 1;
        int b = 1;

        for (int i = 0; i < 10; i++)
        {
            number = a + b;
            a = b;
            b = number;
            array += b;
        }

        Console.WriteLine("11" + array);


        //**** ilk başta 2 ile başlamak için değişkenleri default olarak 1 atıyorum sonra döngüde ilk iki değeri topluyor.
        //sonra b yi a ya atıyor böylece bir önceki değeri tutmuş oluyorum b ye de toplanan değeri atıyorum sonra diziye ekliyorum.
        //böylece her seferinde son iki değeri toplamış oluyoruz. ****


    }

}
